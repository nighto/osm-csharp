using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsmCsharp.Elements
{
    public abstract class OsmElement
    {
        public int Id { get; set; }
        public bool Visible { get; set; }
        public DateTime Timestamp { get; set; }
        public int Version { get; set; }
        public int Changeset { get; set; }
        public string User { get; set; }
        public int Uid { get; set; }
    }
}
