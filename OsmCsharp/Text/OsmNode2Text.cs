using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;

namespace OsmCsharp.OSM2Text
{
    public class Text
    {
        public string OsmNode2Text(OsmNode node)
        {
            string result = string.Empty;
            string br = "\n";

            result += "Node" + br + br;
            result += "ID: " + node.Id.ToString() + br;
            result += "Lat/Lon: " + node.Lat.ToString() + ", " + node.Lon.ToString() + br;
            result += "Version: " + node.Version.ToString() + br;
            result += "Changeset: " + node.Changeset.ToString() + br;
            result += "User: " + node.User + br;
            result += "UID: " + node.Uid.ToString() + br;
            result += "Visible: " + node.Visible.ToString() + br;
            result += "Timestamp: " + node.Timestamp.ToString() + br + br;

            result += "Tags: " + br;
            foreach (Tag tag in node.TagList)
                result += tag.Key + "=" + tag.Value + br;

            return result;
        }
    }
}
