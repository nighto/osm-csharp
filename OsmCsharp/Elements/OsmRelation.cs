using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsmCsharp.Elements
{
    public class OsmRelation : OsmElement
    {
        public List<RelationMember> MembersList { get; set; }
        public List<Tag> TagsList { get; set; }
    }
}
