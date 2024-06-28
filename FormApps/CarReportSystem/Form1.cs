using System.ComponentModel;
using System.Diagnostics.Metrics;

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
                Auther = cbAuther.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbCarReport.Text,
                //Picture =

            };
            listCarReports.Add(carReport);
        }

        //選択されているメーカーを列挙型で返す
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if(rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            }
            else if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            }
            else if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            }
            else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            }
            else if (rbInport.Checked) {
                return CarReport.MakerGroup.輸入車;
            }
            else return CarReport.MakerGroup.その他;
        }
    }
}
