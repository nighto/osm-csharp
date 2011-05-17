using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsmCsharp.Elements
{
    public class OsmNode : OsmElement
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
        public List<Tag> TagList { get; set; }
    }
}
