using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;

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
    }
}
