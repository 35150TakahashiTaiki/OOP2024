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
                          today.ToString("yyyy年MM月dd日　HH時mm分ss秒") + "\r\n" +
                          today.ToString("ggyy年M月d日(dddd)", culture);
        }

        private void btEX8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            DateTime nextWeekMon = NextDay(today,DayOfWeek.Monday);
            DateTime nextWeekThes = NextDay(today, DayOfWeek.Tuesday);
            DateTime nextWeekWed = NextDay(today, DayOfWeek.Wednesday);
            DateTime nextWeekThurs = NextDay(today, DayOfWeek.Thursday);
            DateTime nextWeekFri = NextDay(today, DayOfWeek.Friday);
            DateTime nextWeekSat = NextDay(today, DayOfWeek.Saturday);
            DateTime nextWeekSun = NextDay(today, DayOfWeek.Sunday);
            tbDisp2.Text = nextWeekMon.ToString("d") + "\r\n" +
                           nextWeekThes.ToString("d") + "\r\n" +
                           nextWeekWed.ToString("d") + "\r\n" +
                           nextWeekThurs.ToString("d") + "\r\n" +
                           nextWeekFri.ToString("d") + "\r\n" +
                           nextWeekSat.ToString("d") + "\r\n" +
                           nextWeekSun.ToString("d");
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
