using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //CarReport管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dvgCarReport.DataSource = listCarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbCarReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);
        }

        //記録者の履歴をコンボボックスへ登録（重複なし）
        private void setCbAuther(string auther) {

        }

        //車名の履歴をコンボボックスへ登録（登録なし）
        private void setCbCarName(string carName) {


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
                    rbHonda.Checked = true;
                    break;
            }

        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dvgCarReport.Columns["Picture"].Visible = false; //Picture列の非表示
        }

        private void dvgCarReport_Click(object sender, EventArgs e) {
            if (dvgCarReport.Rows.Count == 0) return;

            dtpDate.Value = (DateTime)dvgCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dvgCarReport.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dvgCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dvgCarReport.CurrentRow.Cells["CarName"].Value;
            tbCarReport.Text = (string)dvgCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dvgCarReport.CurrentRow.Cells["Picture"].Value;

        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            listCarReports.RemoveAt(dvgCarReport.CurrentRow.Index);

        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            listCarReports[dvgCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dvgCarReport.CurrentRow.Index].Author= cbAuthor.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dvgCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Report = tbCarReport.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Picture = pbPicture.Image;
      
            dvgCarReport.Refresh();//データグリッドビューの更新
        }
    }
}
