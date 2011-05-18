using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using OsmCsharp.Elements;

namespace OsmCsharp.Parsers
{
    public abstract class OsmElementParser
    {
        /// <summary>
        /// API URL from URLs Resource File.
        /// </summary>
        static internal string apiurl = URLs.API_URL;

        /// <summary>
        /// Gets the XML from OSM API.
        /// </summary>
        /// <param name="uri">Full element's URI on OSM API.</param>
        /// <returns>XML Document with element data.</returns>
        internal XmlDocument FetchElementXml(string uri)
        {
            var xmlDoc = new XmlDocument();
            var reader = XmlReader.Create(uri);

            xmlDoc.Load(reader);
            reader.Close();
            
            return xmlDoc;
        }

        /// <summary>
        /// Fills element's basic attributes.
        /// </summary>
        /// <param name="elementXmlNode">XML node with element's data.</param>
        /// <param name="osmElement">Reference to OsmNode, OsmWay or OsmRelation.</param>
        public void FetchBasicAttributes(XmlNode elementXmlNode, OsmElement osmElement)
        {
            osmElement.Id = int.Parse(elementXmlNode.Attributes["id"].Value);
            osmElement.Version = int.Parse(elementXmlNode.Attributes["version"].Value);
            osmElement.Changeset = int.Parse(elementXmlNode.Attributes["changeset"].Value);
            osmElement.User = elementXmlNode.Attributes["user"].Value;
            osmElement.Uid = int.Parse(elementXmlNode.Attributes["uid"].Value);
            osmElement.Visible = Convert.ToBoolean(elementXmlNode.Attributes["visible"].Value);
            osmElement.Timestamp = DateTime.Parse(elementXmlNode.Attributes["timestamp"].Value).ToUniversalTime();
        }
    }
}
