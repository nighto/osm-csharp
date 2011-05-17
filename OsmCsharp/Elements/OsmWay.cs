using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsmCsharp.Elements
{
    public class OsmWay : OsmElement
    {
        public List<OsmNode> NodesList { get; set; }
        public List<Tag> TagList { get; set; }
    }
}
