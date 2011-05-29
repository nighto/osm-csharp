using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;

namespace OsmCsharp.Parsers
{
    public class OsmWayParser : OsmElementParser
    {
        private static string wayApiUrl = apiurl + "way/";

        public void FetchBasicAttributes(XmlNode elementXmlNode, ref OsmWay osmWay)
        {
            FetchBasicAttributes(elementXmlNode, (OsmElement)osmWay);
        }

        public OsmWay FetchOsmWay(int id)
        {
            var xmlWay = FetchElementXml(wayApiUrl + id.ToString());
            var osmWay = new OsmWay();

            //API always returns a single way.
            XmlNode elementXmlWay = xmlWay.GetElementsByTagName("way")[0];

            //Reading Metadata
            FetchBasicAttributes(elementXmlWay, ref osmWay);

            //Reading Way Nodes
            var nodeList = new List<OsmNode>();
            XmlNodeList xmlNodes = xmlWay.GetElementsByTagName("nd");

            foreach (XmlNode xmlNode in xmlNodes)
            {
                var nodeRef = int.Parse(xmlNode.Attributes["ref"].Value);
                var nodeParser = new OsmNodeParser();
                var node = new OsmNode();

                node = nodeParser.FetchOsmNode(nodeRef);
                nodeList.Add(node);
            }
            
            osmWay.NodesList = nodeList;

            //Reading Way Tags
            var tagList = new List<Tag>();
            XmlNodeList tagXmlNodes = xmlWay.GetElementsByTagName("tag");

            foreach (XmlNode tagXml in tagXmlNodes)
            {
                var tag = new Tag();
                tag.Key = tagXml.Attributes["k"].Value;
                tag.Value = tagXml.Attributes["v"].Value;
                tagList.Add(tag);
            }

            osmWay.TagList = tagList;

            return osmWay;
        }
    }
}
