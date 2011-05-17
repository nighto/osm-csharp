using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;

namespace OsmCsharp.Parsers
{
    public class OsmRelationParser : OsmElementParser
    {
        private static string relationApiUrl = apiurl + "relation/";

        public void FetchBasicAttributes(XmlNode elementXmlNode, ref OsmRelation osmRelation)
        {
            FetchBasicAttributes(elementXmlNode, (OsmElement)osmRelation);
        }

        public OsmRelation FetchOsmRelation(int id)
        {
            var xmlRelation = FetchElementXml(relationApiUrl + id.ToString());
            var osmRelation = new OsmRelation();

            //API always returns a single relation.
            XmlNode elementXmlRelation = xmlRelation.GetElementsByTagName("relation")[0];

            //Reading metadata.
            FetchBasicAttributes(elementXmlRelation, osmRelation);

            throw new NotImplementedException();
        }
    }
}
