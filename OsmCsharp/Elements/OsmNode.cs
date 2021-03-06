﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Converters;
using System.Xml;

namespace OsmCsharp.Elements
{
    public class OsmNode : OsmElement
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
        public List<Tag> TagList { get; set; }

        public override string ToString()
        {
            return OsmNodeConverterExtension.ToString(this);
        }

        public XmlDocument ToXml()
        {
            return OsmNodeConverterExtension.ToXml(this);
        }

        public string ToXmlString()
        {
            return OsmNodeConverterExtension.ToXmlString(this);
        }

        public string ToJson()
        {
            return OsmNodeConverterExtension.ToJson(this);
        }
    }
}
