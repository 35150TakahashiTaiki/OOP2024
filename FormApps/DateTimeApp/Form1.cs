using System.Numerics;
using System.Windows.Forms;

namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            TimeSpan diff = today - dtpDay.Value;
            tbDisp.Text = diff.Days + 1 + "ì˙ñ⁄";
        }

        private void BtDaybefor_Click(object sender, EventArgs e) {
            var day = dtpDay.Value;
            var past = day.AddDays(-(int)nud.Value);
            tbDisp.Text = past.ToString("D");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var day = dtpDay.Value;
            var future = day.AddDays((int)nud.Value);
            tbDisp.Text = future.ToString("D");
        }

        private void btOld_Click(object sender, EventArgs e) {
            var birthday = dtpDay.Value;
            var today = DateTime.Today;
            int age = GetAge(birthday, today);
            tbDisp.Text = age.ToString("D")+"çÀ";
        }

        private static int GetAge(DateTime birthday, DateTime today) {
            var age = today.Year - birthday.Year;
            if (today < birthday.AddYears(age).AddDays(-1)) {
                age--;
            }
            return age;
        }
    }
}
