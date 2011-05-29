using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OsmCsharp.Elements;
using OsmCsharp.Parsers;
using OsmCsharp.Converters;

namespace TestGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (nodeRadioButton.Checked)
            {
                var node = new OsmNode();
                var parser = new OsmNodeParser();

                node = parser.FetchOsmNode(int.Parse(textBoxElementId.Text));

                var strNode = String.Empty;

                if (textRadioButton.Checked)
                    strNode = node.ToString();
                else
                    if (XMLRadioButton.Checked)
                        strNode = node.ToXmlString();

                MessageBox.Show(strNode);
            }
            else
            {
                if (wayRadioButton.Checked)
                {
                    var way = new OsmWay();
                    var parser = new OsmWayParser();

                    way = parser.FetchOsmWay(int.Parse(textBoxElementId.Text));

                    var strWay = String.Empty;

                    if (textRadioButton.Checked)
                        strWay = way.ToString();
                    else
                        if (XMLRadioButton.Checked)
                            strWay = way.ToXmlString();

                    MessageBox.Show(strWay);
                }
                else
                {
                    if (relationRadioButton.Checked)
                    {
                        var relation = new OsmRelation();
                        var parser = new OsmRelationParser();

                        relation = parser.FetchOsmRelation(int.Parse(textBoxElementId.Text));

                        var strRelation = String.Empty;

                        if (textRadioButton.Checked)
                            strRelation = relation.ToString();
                        else
                            if (XMLRadioButton.Checked)
                                strRelation = relation.ToFullXmlString();

                        MessageBox.Show(strRelation);
                    }
                }
            }
        }
    }
}
