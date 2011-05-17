using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmCsharp.Elements;
using System.Xml;

namespace OsmCsharp.Parsers
{
    public class OsmWayParser : OsmElementParser
    {
        private static string wayApiUrl = apiurl + "way/";

        public void FetchBasicAttributes(XmlNode elementXmlNode, ref OsmWay osmWay)
        {
            FetchBasicAttributes(elementXmlNode, (OsmElement)osmWay);
        }

        public OsmWay FetchOsmWay(int id)
        {
            var xmlWay = FetchElementXml(wayApiUrl + id.ToString());
            var osmWay = new OsmWay();

            //API always returns a single way.
            XmlNode elementXmlWay = xmlWay.GetElementsByTagName("way")[0];

            //Reading Metadata
            FetchBasicAttributes(elementXmlWay, ref osmWay);

            //Reading Ways

            throw new NotImplementedException();
        }
    }
}
