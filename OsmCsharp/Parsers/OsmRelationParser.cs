    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;

namespace OsmCsharp.Parsers
{
    public class OsmRelationParser : OsmElementParser
    {
        private static string relationApiUrl = apiurl + "relation/";

        public void FetchBasicAttributes(XmlNode elementXmlNode, ref OsmRelation osmRelation)
        {
            FetchBasicAttributes(elementXmlNode, (OsmElement)osmRelation);
        }

        public OsmRelation FetchOsmRelation(int id)
        {
            var xmlRelation = FetchElementXml(relationApiUrl + id.ToString());
            var osmRelation = new OsmRelation();

            //API always returns a single relation.
            XmlNode elementXmlRelation = xmlRelation.GetElementsByTagName("relation")[0];

            //Reading Metadata
            FetchBasicAttributes(elementXmlRelation, osmRelation);

            //Reading Relation Members
            var relationMemberList = new List<RelationMember>();
            XmlNodeList relationXmlNodes = xmlRelation.GetElementsByTagName("member");

            foreach (XmlNode tagXml in relationXmlNodes)
            {
                var member = new RelationMember();
                var memberType = tagXml.Attributes["type"].Value;
                var memberId = int.Parse(tagXml.Attributes["ref"].Value);
                member.Role = tagXml.Attributes["role"].Value;

                if (memberType == "node")
                {
                    var node = new OsmNode();
                    var nodeParser = new OsmNodeParser();
                    node = nodeParser.FetchOsmNode(memberId);
                    relationMemberList.Add(node);
                }
                else
                {
                    if (memberType == "way")
                    {
                        var way = new OsmWay();
                        var wayParser = new OsmWayParser();
                        way = wayParser.FetchOsmWay(memberId);
                        relationMemberList.Add(way);
                    }
                }
            }

            //Reading Relation Tags
            var tagList = new List<Tag>();
            XmlNodeList tagXmlNodes = xmlRelation.GetElementsByTagName("tag");

            foreach (XmlNode tagXml in tagXmlNodes)
            {
                var tag = new Tag();
                tag.Key = tagXml.Attributes["k"].Value;
                tag.Value = tagXml.Attributes["v"].Value;
                tagList.Add(tag);
            }

            osmRelation.TagList = tagList;

            return osmRelation;
        }
    }
}
