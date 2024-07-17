using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class FmVersion : Form {
        public FmVersion() {
            InitializeComponent();
        }

        private void btVersionOk_Click(object sender, EventArgs e) {
            Close();
        }

        private void FmVersion_Load(object sender, EventArgs e) {
            
            var location = Assembly.GetExecutingAssembly().Location;
            var ver =FileVersionInfo.GetVersionInfo(location);
            labelver.Text = "ver"+ver.FileVersion;
            labelText.Text = "copyright("+ver.LegalCopyright+")"+" "+
                             ver.CompanyName;

        }
    }
}
