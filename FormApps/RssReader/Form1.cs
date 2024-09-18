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
using Microsoft.Web.WebView2.Core;
using Windows.UI.Xaml.Controls;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RssReader {
    public partial class Form1 : Form {
        readonly CountdownEvent condition = new CountdownEvent(1);
        public Form1() {

            InitializeComponent();
            
        }

        async void InitializeAsync() {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.NavigationCompleted += webView21_NavigationCompleted;
        }

        List<ItemData> xitems;

        List<string> topics = new List<string> {
            "主要", "国内", "国際", "経済", "エンタメ", "スポーツ", "IT", "科学", "地域"
        };

        private void btGet_Click(object sender, EventArgs e) {
            using(var wc = new WebClient()) {
                var url = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                 xitems = xdoc.Root.Descendants("item").Select(item => new ItemData {
                    Title = item.Element("title").Value,
                    Link = item.Element("link").Value,

                }).ToList();

                foreach (var item in xitems)
                {
                   
                    lbRssTitle.Items.Add(item.Title);
                    
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitializeAsync();

            cbRssUrl.Items.AddRange(topics.ToArray());
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            
            
            webView21.CoreWebView2.Navigate(xitems[lbRssTitle.SelectedIndex].Link);
        }
        
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }

        private void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e) {
            //読み込み結果を判定
            if (e.IsSuccess)
                Console.WriteLine("complete");
            else
                Console.WriteLine(e.WebErrorStatus);

            //シグナル初期化
            condition.Signal();
            System.Threading.Thread.Sleep(1);
            condition.Reset();
        }

    }
}
