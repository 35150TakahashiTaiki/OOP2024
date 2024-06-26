using Microsoft.VisualBasic;
using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEX8_1_Click(object sender, EventArgs e) {
            var today = DateTime.Now;

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            tbDisp.Text = today.ToString("F") + "\r\n" +
                          today.ToString("yyyy”NMMŒdd“ú@HHmm•ªss•b") + "\r\n" +
                          today.ToString("ggyy”NMŒd“ú(dddd)", culture);
        }

        private void btEX8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                DateTime nextWeek = NextDay(today, (DayOfWeek)dayofweek);
                var str = string.Format("{0:yy/MM/dd}‚ÌŸT‚Ì{1}:{2}", today, (DayOfWeek)dayofweek, nextWeek.ToString("d"));
                tbDisp2.Text += str + "\r\n";
            }

        }

        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            days += 7;
            return date.AddDays(days);
        }

        private void btEx8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(500);
            TimeSpan duration = tw.Stop();
            var str = string.Format("ˆ—ŠÔ‚Í{0}ƒ~ƒŠ•b‚Å‚µ‚½",duration.TotalSeconds);
            tbDisp3.Text = str;
        }
    }

    class TimeWatch {
        private DateTime date;
        public void Start() {
            date = DateTime.Now;
        }

        public TimeSpan Stop() {
        var stop = DateTime.Now;
            return stop- date;
        }
    }
}
