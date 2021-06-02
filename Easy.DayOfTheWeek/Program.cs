using System;

namespace Easy.DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDayOfTheWeek(31, 8, 2019));
        }

        public static string GetDayOfTheWeek(int day, int month, int year)
        {
            var dateTime = new DateTime(year, month, day);
            return dateTime.DayOfWeek.ToString();
        }
    }
}
