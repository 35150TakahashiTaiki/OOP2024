using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using(var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                foreach (var item in xdoc.Root.Descendants("item"))
                {
                    XElement xtitle = item.Element("title");
                    XElement xlink = item.Element("link");
                    lbRssTitle.Items.Add(xtitle.Value);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            webBrowser1.Navigate("xlink.Value");
        }
    }
}
