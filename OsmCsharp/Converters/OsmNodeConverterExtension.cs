using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace OsmCsharp.Converters
{
    public static class OsmNodeConverterExtension
    {
        /// <summary>
        /// Returns a string with node properties
        /// </summary>
        /// <param name="node">OsmNode</param>
        /// <returns>string</returns>
        public static string ToString(this OsmNode node)
        {
            StringBuilder result = new StringBuilder();
            const string br = "\n";

            result.Append("Node");
            result.Append(br);
            result.Append(br);

            result.Append("ID: ");
            result.Append(node.Id);
            result.Append(br);

            result.Append("Lat/Lon: ");
            result.Append(node.Lat);
            result.Append(", ");
            result.Append(node.Lon);
            result.Append(br);

            result.Append("Version: ");
            result.Append(node.Version);
            result.Append(br);

            result.Append("Changeset: ");
            result.Append(node.Changeset);
            result.Append(br);

            result.Append("User: ");
            result.Append(node.User);
            result.Append(br);

            result.Append("UID: ");
            result.Append(node.Uid);
            result.Append(br);

            result.Append("Visible: ");
            result.Append(node.Visible);
            result.Append(br);

            result.Append("Timestamp: ");
            result.Append(node.Timestamp);
            result.Append(br);

            result.Append(br);
            result.Append("Tags");
            result.Append(br);

            foreach (Tag tag in node.TagList)
            {
                result.Append(tag.Key);
                result.Append("=");
                result.Append(tag.Value);
                result.Append(br);
            }

            return result.ToString();
        }

        /// <summary>
        /// Returns a XmlDocument with node properties, just like OSM API.
        /// </summary>
        /// <param name="node">OsmNode</param>
        /// <returns>XmlDocument</returns>
        public static XmlDocument ToXml(this OsmNode node)
        {
            // Creates a new XML document.
            XmlDocument doc = new XmlDocument();

            // Creates a declaration and appends it to the XML document.
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);

            // Creates the root <osm> element and appends it to the XML document.
            XmlElement rootElement = doc.CreateElement("osm");
            rootElement.SetAttribute("version", "0.6");
            rootElement.SetAttribute("generator", "OsmCsharp");
            doc.AppendChild(rootElement);

            // Creates the <node> element and appends it to the <osm> element on the XML document.
            XmlElement nodeElement = doc.CreateElement("node");
            nodeElement.SetAttribute("id", node.Id.ToString());
            nodeElement.SetAttribute("lat", node.Lat.ToString());
            nodeElement.SetAttribute("lon", node.Lon.ToString());
            nodeElement.SetAttribute("version", node.Version.ToString());
            nodeElement.SetAttribute("changeset", node.Changeset.ToString());
            nodeElement.SetAttribute("user", node.User);
            nodeElement.SetAttribute("uid", node.Uid.ToString());
            nodeElement.SetAttribute("visible", node.Visible.ToString().ToLower());
            nodeElement.SetAttribute("timestamp", String.Format("{0:yyyy-MM-dd\\THH:mm:ss\\Z}", node.Timestamp));
            rootElement.AppendChild(nodeElement);

            //Iterates through all tags, creates <tag> elements and append them to the <node> element on the XML document.
            foreach (Tag tag in node.TagList)
            {
                XmlElement tagElement = doc.CreateElement("tag");
                tagElement.SetAttribute("k", tag.Key);
                tagElement.SetAttribute("v", tag.Value);
                nodeElement.AppendChild(tagElement);
            }

            //Finally, spits the XML.
            return doc;
        }

        /// <summary>
        /// Returns a string with node properties as XML, just like OSM API.
        /// </summary>
        /// <param name="node">OsmNode</param>
        /// <returns>string</returns>
        public static string ToXmlString(this OsmNode node)
        {
            return node.ToXml().OuterXml;
        }
        
        /// <summary>
        /// Returns a string with node properties as JSON.
        /// </summary>
        /// <param name="node">OsmNode</param>
        /// <returns>string</returns>
        public static string ToJson(this OsmNode node)
        {
            throw new NotImplementedException();
        }
    }
}
