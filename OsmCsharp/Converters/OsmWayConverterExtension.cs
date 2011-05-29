using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;
using System.IO;

namespace OsmCsharp.Converters
{
    public static class OsmWayConverterExtension
    {
        /// <summary>
        /// Returns a string with way properties
        /// </summary>
        /// <param name="node">OsmWay</param>
        /// <returns>string</returns>
        public static string ToString(this OsmWay way)
        {
            StringBuilder result = new StringBuilder();
            const string br = "\n";

            result.Append("Way");
            result.Append(br);
            result.Append(br);

            result.Append("ID: ");
            result.Append(way.Id);
            result.Append(br);

            result.Append("Version: ");
            result.Append(way.Version);
            result.Append(br);

            result.Append("Changeset: ");
            result.Append(way.Changeset);
            result.Append(br);

            result.Append("User: ");
            result.Append(way.User);
            result.Append(br);

            result.Append("UID: ");
            result.Append(way.Uid);
            result.Append(br);

            result.Append("Visible: ");
            result.Append(way.Visible);
            result.Append(br);

            result.Append("Timestamp: ");
            result.Append(way.Timestamp);
            result.Append(br);

            result.Append(br);
            result.Append("Tags");
            result.Append(br);

            foreach (Tag tag in way.TagList)
            {
                result.Append(tag.Key);
                result.Append("=");
                result.Append(tag.Value);
                result.Append(br);
            }

            result.Append(br);
            result.Append("Nodes");
            result.Append(br);

            foreach (OsmNode node in way.NodesList)
            {
                result.Append(node.ToString());
            }

            return result.ToString();
        }

        /// <summary>
        /// Returns a XmlDocument with way properties, just like OSM API, plus full nodes properties.
        /// </summary>
        /// <param name="node">OsmWay</param>
        /// <returns>XmlDocument</returns>
        public static XmlDocument ToXml(this OsmWay way)
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

            // Creates the <way> element and appends it to the <osm> element on the XML document.
            XmlElement wayElement = doc.CreateElement("way");
            wayElement.SetAttribute("id", way.Id.ToString());
            wayElement.SetAttribute("version", way.Version.ToString());
            wayElement.SetAttribute("changeset", way.Changeset.ToString());
            wayElement.SetAttribute("user", way.User);
            wayElement.SetAttribute("uid", way.Uid.ToString());
            wayElement.SetAttribute("visible", way.Visible.ToString().ToLower());
            wayElement.SetAttribute("timestamp", String.Format("{0:yyyy-MM-dd\\THH:mm:ss\\Z}", way.Timestamp));
            rootElement.AppendChild(wayElement);

            //Iterates through all way nodes, creates <nd> elements and append them to the <way> element
            foreach (OsmNode node in way.NodesList)
            {
                XmlElement nodeElement = doc.CreateElement("nd");
                nodeElement.SetAttribute("ref", node.Id.ToString());
                wayElement.AppendChild(nodeElement);
            }

            //Iterates through all tags, creates <tag> elements and append them to the <way> element on the XML document.
            foreach (Tag tag in way.TagList)
            {
                XmlElement tagElement = doc.CreateElement("tag");
                tagElement.SetAttribute("k", tag.Key);
                tagElement.SetAttribute("v", tag.Value);
                wayElement.AppendChild(tagElement);
            }

            //Iterates through all way nodes again, now importing full <node> elements to the <way> element
            foreach (OsmNode node in way.NodesList)
            {
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
            }

            //Finally, spits the XML.
            return doc;
        }

        /// <summary>
        /// Returns a XmlDocument with way properties, just like OSM API, plus full nodes properties.
        /// </summary>
        /// <param name="node">OsmWay</param>
        /// <returns>string</returns>
        public static string ToXmlString(this OsmWay way)
        {
            var stringWriter = new StringWriter(new StringBuilder());
            var xmlTextWriter = new XmlTextWriter(stringWriter)
            {
                Formatting = Formatting.Indented
            };
            way.ToXml().Save(xmlTextWriter);

            return stringWriter.ToString();
        }

        /// <summary>
        /// Returns a string with way properties as JSON.
        /// </summary>
        /// <param name="node">OsmWay</param>
        /// <returns>string</returns>
        public static string ToJson(this OsmWay way)
        {
            throw new NotImplementedException();
        }
    }
}
