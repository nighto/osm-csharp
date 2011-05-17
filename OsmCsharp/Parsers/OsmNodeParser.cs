using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;

namespace OsmCsharp.Parsers
{
    public class OsmNodeParser : OsmElementParser
    {
        private static string nodeApiUrl = apiurl + "node/";

        public void FetchBasicAttributes(XmlNode elementXmlNode, ref OsmNode osmNode)
        {
            FetchBasicAttributes(elementXmlNode, (OsmElement)osmNode);
        }

        public OsmNode FetchOsmNode(int id)
        {
            var xmlNode = FetchElementXml(nodeApiUrl + id.ToString());
            var osmNode = new OsmNode();

            //API always returns a single node.
            XmlNode elementXmlNode = xmlNode.GetElementsByTagName("node")[0];

            //Reading Metadata
            FetchBasicAttributes(elementXmlNode, ref osmNode);
            osmNode.Lat = float.Parse(elementXmlNode.Attributes["lat"].Value);
            osmNode.Lon = float.Parse(elementXmlNode.Attributes["lon"].Value);

            //Reading Tags
            var tagList = new List<Tag>();
            XmlNodeList tagXmlNodes = xmlNode.GetElementsByTagName("tag");

            foreach (XmlNode tagXml in tagXmlNodes)
            {
                var tag = new Tag();
                tag.Key = tagXml.Attributes["k"].Value;
                tag.Value = tagXml.Attributes["v"].Value;
                tagList.Add(tag);
            }

            osmNode.TagList = tagList;
            return osmNode;
        }
    }
}
