using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace CarReportSystem {
    public partial class Form1 : Form {

        //CarReport管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dvgCarReport.DataSource = listCarReports;
        }

        //設定クラスのインスタンス生成
        Settings? settings = Settings.getInstance();

        private void btAddReport_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "記録者または車名が未入力";
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbCarReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);
            setCbAuther(carReport.Author);
            setCbCarName(carReport.CarName);
            clearText();
            dvgCarReport.ClearSelection();

        }

        //記録者の履歴をコンボボックスへ登録（重複なし）
        private void setCbAuther(string auther) {
            if (!cbAuthor.Items.Contains(auther)) {
                cbAuthor.Items.Add(auther);
            }
        }

        //車名の履歴をコンボボックスへ登録（重複なし）
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }

        }

        //選択されているメーカーを列挙型で返す
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            } else if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            } else if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            } else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            } else if (rbInport.Checked) {
                return CarReport.MakerGroup.輸入車;
            } else return CarReport.MakerGroup.その他;
        }

        //指定したラジオボタンをセット
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.なし:
                    clearRadioButton();
                    break;

                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbInport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbAther.Checked = true;
                    break;
            }

        }

        private void clearRadioButton() {
            rbToyota.Checked = false;
            rbNissan.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbInport.Checked = false;
            rbAther.Checked = false;
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }
        //画像削除
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dvgCarReport.Columns["Picture"].Visible = false; //Picture列の非表示
            //交互に色を設定（データグリッドビュー）
            dvgCarReport.RowsDefaultCellStyle.BackColor = Color.Cyan;
            dvgCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            //設定ファイルを逆シリアル化して背景を設定
            if (File.Exists("settings.xml")) {    
                try {
                    using (var reader = XmlReader.Create("settings.xml")) {
                        var serializer = new XmlSerializer(typeof(Settings));
                        settings = serializer.Deserialize(reader) as Settings;
                        BackColor = Color.FromArgb(settings.MainFormColor);
                        settings.MainFormColor = BackColor.ToArgb();
                    }
                }
                catch (Exception) {
                    
                }
            } else {
                tslbMessage.Text = "色情報ファイルがありません";
            }

        }
        

        private void dvgCarReport_Click(object sender, EventArgs e) {
            if ((dvgCarReport.Rows.Count == 0) || (!dvgCarReport.CurrentRow.Selected)) return;

            dtpDate.Value = (DateTime)dvgCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dvgCarReport.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dvgCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dvgCarReport.CurrentRow.Cells["CarName"].Value;
            tbCarReport.Text = (string)dvgCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dvgCarReport.CurrentRow.Cells["Picture"].Value;

        }

        //削除
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if (listCarReports.Count == 0 || (!dvgCarReport.CurrentRow.Selected)) return;
            listCarReports.RemoveAt(dvgCarReport.CurrentRow.Index);
            clearText();
            dvgCarReport.ClearSelection();
        }
        //修正
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (listCarReports.Count == 0 || (!dvgCarReport.CurrentRow.Selected)) return;


            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "記録者または車名が未入力";
                return;
            }

            listCarReports[dvgCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dvgCarReport.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dvgCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Report = tbCarReport.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Picture = pbPicture.Image;

            dvgCarReport.Refresh();//データグリッドビューの更新
        }

        //クリア
        private void clearText() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = "";
            setRadioButtonMaker(CarReport.MakerGroup.なし);
            cbCarName.Text = "";
            tbCarReport.Text = "";
            pbPicture.Image = null;
            dvgCarReport.ClearSelection();
        }

        //記録者のテキストが変更されたら
        private void cbAuthor_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }
        //車名のテキストが変更されたら
        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }
        //保存
        private void btReportSave_Click(object sender, EventArgs e) {
            ReportSaveFile();
        }

        private void ReportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception) {

                    tslbMessage.Text = "書き込みエラー";
                }
            }
        }

        //開く
        private void btReportOpen_Click(object sender, EventArgs e) {
            ReportOpenFile();
        }

        private void ReportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    tslbMessage.Text = "";
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dvgCarReport.DataSource = listCarReports;

                        foreach (var carReport in listCarReports) {
                            setCbAuther(carReport.Author);
                            setCbCarName(carReport.CarName);
                        }
                    }
                }
                catch (Exception ex) {

                    tslbMessage.Text = "ファイル形式が違います";
                }
            }
            dvgCarReport.ClearSelection();
        }

        private void btclearText_Click(object sender, EventArgs e) {
            clearText();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportOpenFile();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportSaveFile();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            var daialog = MessageBox.Show("本当に終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (daialog == DialogResult.Yes)
                Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            //ダイアログを表示する
            if (cdColor.ShowDialog() == DialogResult.OK) {
                //選択した色を取得               
                this.BackColor = cdColor.Color;//背景色設定
                settings.MainFormColor = cdColor.Color.ToArgb();//背景色保存

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            try {
                using(var writer = XmlWriter.Create("settings.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(writer, settings);
                }          
            }
            catch(Exception) {
                MessageBox.Show("設定ファイル書き込みエラー");
            }
        }
    }
}
