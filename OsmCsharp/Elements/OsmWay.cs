using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Converters;
using System.Xml;

namespace OsmCsharp.Elements
{
    public class OsmWay : OsmElement
    {
        public List<OsmNode> NodesList { get; set; }
        public List<Tag> TagList { get; set; }

        public override string ToString()
        {
            return OsmWayConverterExtension.ToString(this);
        }

        public XmlNode ToXml()
        {
            return OsmWayConverterExtension.ToXml(this);
        }

        public XmlDocument ToFullXml()
        {
            return OsmWayConverterExtension.ToFullXml(this);
        }

        public string ToXmlString()
        {
            return OsmWayConverterExtension.ToXmlString(this);
        }

        public string ToFullXmlString()
        {
            return OsmWayConverterExtension.ToFullXmlString(this);
        }

        public string ToJson()
        {
            return OsmWayConverterExtension.ToJson(this);
        }
    }
}
