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
                          today.ToString("yyyyîNMMåéddì˙Å@HHéûmmï™ssïb") + "\r\n" +
                          today.ToString("ggyyîNMåédì˙(dddd)", culture);
        }

        private void btEX8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            DateTime nextWeek = NextDay(today,DayOfWeek.Monday);
            tbDisp2.Text = nextWeek.ToString();
        }

        public static DateTime NextDay(DateTime date,DayOfWeek dayOfWeek) {
            var days =(int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 0) {
                days += 7;
                return date.AddDays(days);
            }
            return date.AddDays(days);
        }
    }
}
