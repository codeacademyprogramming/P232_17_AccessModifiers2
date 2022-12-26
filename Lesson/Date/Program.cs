using System;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");

            DateTime date1 = new DateTime();
            date1 = new DateTime(2022, 10, 20, 14, 30, 0);

            Console.WriteLine(date1);

            date1 = date1.AddDays(1);
            date1 = date1.AddYears(-11);
            date1 = date1.AddMonths(1);
            date1 = date1.AddHours(1);


            Console.WriteLine(date1.ToString("yyyy-MM-dd HH:mm"));

            string dateStr = "10-22-2011 01:30";
            DateTime newDate = Convert.ToDateTime(dateStr);

            Console.WriteLine(newDate.ToString("MM/dd/yyyy"));


            DateTime startDate = new DateTime(2022, 12, 26, 14, 30, 0);
            DateTime endDate = new DateTime(2022, 12, 27, 18,0, 0);

            var diff = endDate - startDate;

            Console.WriteLine(diff.Minutes);
            Console.WriteLine(diff.TotalMinutes);


            Console.WriteLine(diff.Hours);
            Console.WriteLine(diff.TotalHours);

            Console.WriteLine(diff.Days);
            Console.WriteLine(diff.TotalDays);

            Console.WriteLine(diff);


            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.DayOfWeek);


            string inputDateStr = Console.ReadLine();
            DateTime inputDate = Convert.ToDateTime(inputDateStr);

            Console.WriteLine(inputDate.DayOfWeek);
            Console.WriteLine(inputDate.ToString("dddd"));



        }
    }
}
