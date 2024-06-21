using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);

            #region 誕生日確認
            DayOfWeek dayOfWeek = birthday.DayOfWeek;
            string japaneseDayOfWeek = GetJapaneseDayOfWeek(dayOfWeek);
            Console.WriteLine("あなたは{0}に生まれました", japaneseDayOfWeek);
            #endregion

            #region 和暦表示
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = birthday.ToString("ggyy年M月d日", culture);
            Console.WriteLine("あなたは{0}に生まれました",str);
            #endregion

            #region 生まれてからの日数
            var now =DateTime.Now;
            TimeSpan ts1 = now - birthday;
            Console.WriteLine("あなたは生まれてから今日で{0}日目です",ts1.Days+1);
            #endregion

            #region 閏年判定
            /*var dt1 = new DateTime(2024,6,19);
            var dt2 = new DateTime(2012,4 , 15, 8, 45, 20);
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);

            var today = DateTime.Today;
            var now = DateTime.Now;
            Console.WriteLine("Today :{0}",today);
            Console.WriteLine("Now :{0}", now);

            var isLeapYear = DateTime.IsLeapYear(2024);
            if (isLeapYear) {
                Console.WriteLine("閏年");
            }else {
                Console.WriteLine("閏年ではない");
            }*/
            #endregion
        }

        //曜日を日本語に変換
        public static string GetJapaneseDayOfWeek(DayOfWeek dayOfWeek) {
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    return "日曜日";
                case DayOfWeek.Monday:
                    return "月曜日";
                case DayOfWeek.Tuesday:
                    return "火曜日";
                case DayOfWeek.Wednesday:
                    return "水曜日";
                case DayOfWeek.Thursday:
                    return "木曜日";
                case DayOfWeek.Friday:
                    return "金曜日";
                case DayOfWeek.Saturday:
                    return "土曜日";
                default:
                    return string.Empty;
            }
        }
    }
}
