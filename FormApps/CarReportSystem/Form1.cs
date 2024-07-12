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

        //CarReport�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dvgCarReport.DataSource = listCarReports;
        }

        //�ݒ�N���X�̃C���X�^���X����
        Settings? settings = Settings.getInstance();

        private void btAddReport_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "�L�^�҂܂��͎Ԗ���������";
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

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbAuther(string auther) {
            if (!cbAuthor.Items.Contains(auther)) {
                cbAuthor.Items.Add(auther);
            }
        }

        //�Ԗ��̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }

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
                case CarReport.MakerGroup.�Ȃ�:
                    clearRadioButton();
                    break;

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
        //�摜�폜
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dvgCarReport.Columns["Picture"].Visible = false; //Picture��̔�\��
            //���݂ɐF��ݒ�i�f�[�^�O���b�h�r���[�j
            dvgCarReport.RowsDefaultCellStyle.BackColor = Color.Cyan;
            dvgCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            //�ݒ�t�@�C�����t�V���A�������Ĕw�i��ݒ�
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
                tslbMessage.Text = "�F���t�@�C��������܂���";
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

        //�폜
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if (listCarReports.Count == 0 || (!dvgCarReport.CurrentRow.Selected)) return;
            listCarReports.RemoveAt(dvgCarReport.CurrentRow.Index);
            clearText();
            dvgCarReport.ClearSelection();
        }
        //�C��
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (listCarReports.Count == 0 || (!dvgCarReport.CurrentRow.Selected)) return;


            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "�L�^�҂܂��͎Ԗ���������";
                return;
            }

            listCarReports[dvgCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dvgCarReport.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dvgCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Report = tbCarReport.Text;
            listCarReports[dvgCarReport.CurrentRow.Index].Picture = pbPicture.Image;

            dvgCarReport.Refresh();//�f�[�^�O���b�h�r���[�̍X�V
        }

        //�N���A
        private void clearText() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = "";
            setRadioButtonMaker(CarReport.MakerGroup.�Ȃ�);
            cbCarName.Text = "";
            tbCarReport.Text = "";
            pbPicture.Image = null;
            dvgCarReport.ClearSelection();
        }

        //�L�^�҂̃e�L�X�g���ύX���ꂽ��
        private void cbAuthor_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }
        //�Ԗ��̃e�L�X�g���ύX���ꂽ��
        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }
        //�ۑ�
        private void btReportSave_Click(object sender, EventArgs e) {
            ReportSaveFile();
        }

        private void ReportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception) {

                    tslbMessage.Text = "�������݃G���[";
                }
            }
        }

        //�J��
        private void btReportOpen_Click(object sender, EventArgs e) {
            ReportOpenFile();
        }

        private void ReportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    tslbMessage.Text = "";
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
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

                    tslbMessage.Text = "�t�@�C���`�����Ⴂ�܂�";
                }
            }
            dvgCarReport.ClearSelection();
        }

        private void btclearText_Click(object sender, EventArgs e) {
            clearText();
        }

        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportOpenFile();
        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportSaveFile();
        }

        private void �I��ToolStripMenuItem_Click(object sender, EventArgs e) {
            var daialog = MessageBox.Show("�{���ɏI�����܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (daialog == DialogResult.Yes)
                Application.Exit();
        }

        private void �F�ݒ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            //�_�C�A���O��\������
            if (cdColor.ShowDialog() == DialogResult.OK) {
                //�I�������F���擾               
                this.BackColor = cdColor.Color;//�w�i�F�ݒ�
                settings.MainFormColor = cdColor.Color.ToArgb();//�w�i�F�ۑ�

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //�ݒ�t�@�C���̃V���A����
            try {
                using(var writer = XmlWriter.Create("settings.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(writer, settings);
                }          
            }
            catch(Exception) {
                MessageBox.Show("�ݒ�t�@�C���������݃G���[");
            }
        }
    }
}
