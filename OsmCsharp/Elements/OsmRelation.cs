using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Converters;
using System.Xml;

namespace OsmCsharp.Elements
{
    public class OsmRelation : OsmElement
    {
        public List<RelationMember> MembersList { get; set; }
        public List<Tag> TagsList { get; set; }

        public override string ToString()
        {
            return OsmRelationConverterExtension.ToString(this);
        }

        public XmlNode ToXml()
        {
            return OsmRelationConverterExtension.ToXml(this);
        }

        public XmlDocument ToFullXml()
        {
            return OsmRelationConverterExtension.ToFullXml(this);
        }

        public string ToXmlString()
        {
            return OsmRelationConverterExtension.ToXmlString(this);
        }

        public string ToFullXmlString()
        {
            return OsmRelationConverterExtension.ToFullXmlString(this);
        }

        public string ToJson()
        {
            return OsmRelationConverterExtension.ToJson(this);
        }
    }
}
