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

        private void btnId_Click(object sender, EventArgs e)
        {
            var node = new OsmNode();
            var parser = new OsmNodeParser();

            node = parser.FetchOsmNode(int.Parse(textBoxElementId.Text));

            var strNode = node.ToString();

            MessageBox.Show(strNode);
        }
    }
}
