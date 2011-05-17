using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsmCsharp.Elements
{
    public class RelationMember
    {
        public string Type { get; set; }
        public int IdRef { get; set; }
        public string Role { get; set; }
    }
}
