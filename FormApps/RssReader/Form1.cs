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
        private Dictionary<string, string> category;// RSSカテゴリの辞書
        private List<ItemData> items;// RSSアイテムのリスト
        private List<ItemData> favorites;// お気に入りアイテムのリスト


        public Form1() {
            InitializeComponent(); // フォームの初期化
            InitializeCategories();// カテゴリの初期化
            favorites = new List<ItemData>(); // お気に入りリストの初期化
        }

        // RSSカテゴリを初期化するメソッド
        private void InitializeCategories() {
            category = new Dictionary<string, string>
            {
                {"主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
                {"国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml"},
                {"国際", "https://news.yahoo.co.jp/rss/topics/world.xml"},
                {"経済", "https://news.yahoo.co.jp/rss/topics/business.xml"},
                {"エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml"},
                {"スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml"},
                {"IT", "https://news.yahoo.co.jp/rss/topics/it.xml"},
                {"科学", "https://news.yahoo.co.jp/rss/topics/science.xml"},
                {"地域", "https://news.yahoo.co.jp/rss/topics/local.xml"},
            };

            cbRssUrl.Items.AddRange(category.Keys.ToArray());// コンボボックスにカテゴリを追加
        }

        // お気に入りにURLを追加するボタンの処理
        private void btToroku_Click(object sender, EventArgs e) {
            var inputTitle = cbName.Text; // cbNameはユーザーが好きなタイトルを入力するコンボボックスの名前
            var inputUrl = cbRssUrl.Text; // cbRssUrlはユーザーが選択したURLのコンボボックスの名前

            // タイトルとURLが空でないかチェック
            if (string.IsNullOrWhiteSpace(inputTitle) || string.IsNullOrWhiteSpace(inputUrl)) {
                MessageBox.Show("タイトルとURLの両方を入力してください。"); // 入力が不足している場合
                return;
            }

            // お気に入りリストに追加
            var newItem = new ItemData { Title = inputTitle, Link = inputUrl };
            if (!favorites.Any(f => f.Title == newItem.Title && f.Link == newItem.Link)) {
                favorites.Add(newItem); // お気に入りリストに追加

                // カテゴリにお気に入りを追加
                if (!category.ContainsKey(inputTitle)) {
                    category.Add(inputTitle, inputUrl); // タイトルとURLを辞書に追加
                    cbRssUrl.Items.Add(inputTitle); // コンボボックスにタイトルを追加
                }

                // cbNameにタイトルを追加
                if (!cbName.Items.Contains(inputTitle)) {
                    cbName.Items.Add(inputTitle); // コンボボックスにお気に入りタイトルを追加
                }

                MessageBox.Show($"「{inputTitle}」をお気に入りに追加しました。"); // 成功メッセージ
            } else {
                MessageBox.Show("このタイトルはすでにお気に入りに存在します。"); // 重複エラーメッセージ
            }
        }


        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }

        // コンボボックスでカテゴリが選択されたときの処理
        private void cbRssUrl_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbRssUrl.SelectedItem == null)
                return;// 選択がない場合は何もしない

            LoadRssFeed(cbRssUrl.SelectedItem.ToString());// RSSフィードを読み込む
        }

        // RSSフィードを読み込むメソッド
        private async void LoadRssFeed(string selectedCategory) {
            lbRssTitle.Items.Clear(); // リストボックスをクリア

            if (category.TryGetValue(selectedCategory, out var rssUrl)) {
                using (var wc = new WebClient()) {
                    try {
                        var data = wc.OpenRead(rssUrl); // RSSデータを非同期で取得
                        var xdoc = XDocument.Load(data); // XMLを解析

                        items = xdoc.Root.Descendants("item")
                            .Select(item => new ItemData {
                                Title = item.Element("title")?.Value ?? "No Title", // タイトルを取得
                                Link = item.Element("link")?.Value ?? "#" // リンクを取得
                            }).ToList();

                        foreach (var item in items) {
                            lbRssTitle.Items.Add(item.Title); // リストボックスにタイトルを追加
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("エラー: " + ex.Message); // エラーの表示
                    }
                }
            } else {
                MessageBox.Show("選択されたカテゴリのURLがありません"); // カテゴリが見つからない場合の表示
            }
        }

        // リストボックスでアイテムが選択されたときの処理
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedItem != null) {
                var selectedTitle = lbRssTitle.SelectedItem.ToString();
                var selectedItem = items.FirstOrDefault(item => item.Title == selectedTitle);
                if (selectedItem != null) {
                    webView21.Source = new Uri(selectedItem.Link); // WebViewにリンクを表示
                }
            }
        }


        // お気に入りからアイテムを削除するボタンの処理
        private void btdelete_Click(object sender, EventArgs e) {
            if (cbName.SelectedItem != null) {
                var selectedTitle = cbName.SelectedItem.ToString();
                var itemToDelete = favorites.FirstOrDefault(f => f.Title == selectedTitle);

                // お気に入りリストから削除
                if (itemToDelete != null) {
                    favorites.Remove(itemToDelete);
                    cbName.Items.Remove(selectedTitle); // コンボボックスから削除

                    // categoryからも削除
                    if (category.ContainsKey(selectedTitle)) {
                        category.Remove(selectedTitle); // カテゴリから削除
                        cbRssUrl.Items.Remove(selectedTitle); // コンボボックスから削除
                    }

                    MessageBox.Show($"「{selectedTitle}」をお気に入りから削除しました。"); // 削除成功メッセージ
                } else {
                    MessageBox.Show("選択されたアイテムはお気に入りに存在しません。"); // 存在しない場合
                }
            } else {
                MessageBox.Show("削除するアイテムを選択してください。"); // アイテム未選択の場合
            }
            cbName.Text = cbName.Text.Trim();
        }
    }
}
