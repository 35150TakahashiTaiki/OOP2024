using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //CarReport�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
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

        //�I������Ă��郁�[�J�[��񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if(rbToyota.Checked) {
                return CarReport.MakerGroup.�g���^;
            }
            else if (rbNissan.Checked) {
                return CarReport.MakerGroup.���Y;
            }
            else if (rbHonda.Checked) {
                return CarReport.MakerGroup.�z���_;
            }
            else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.�X�o��;
            }
            else if (rbInport.Checked) {
                return CarReport.MakerGroup.�A����;
            }
            else return CarReport.MakerGroup.���̑�;
        }
    }
}
