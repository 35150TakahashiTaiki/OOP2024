using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

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
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbCarReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);
        }

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbAuther(string auther) {

        }

        //�Ԗ��̗������R���{�{�b�N�X�֓o�^�i�o�^�Ȃ��j
        private void setCbCarName(string carName) {


        }

        //�I������Ă��郁�[�J�[��񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.�g���^;
            } else if (rbNissan.Checked) {
                return CarReport.MakerGroup.���Y;
            } else if (rbHonda.Checked) {
                return CarReport.MakerGroup.�z���_;
            } else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.�X�o��;
            } else if (rbInport.Checked) {
                return CarReport.MakerGroup.�A����;
            } else return CarReport.MakerGroup.���̑�;
        }

        //�w�肵�����W�I�{�^�����Z�b�g
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
                    rbInport.Checked = true;
                    break;
                case CarReport.MakerGroup.���̑�:
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
            dvgCarReport.Columns["Picture"].Visible = false; //Picture��̔�\��
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
      
            dvgCarReport.Refresh();//�f�[�^�O���b�h�r���[�̍X�V
        }
    }
}
