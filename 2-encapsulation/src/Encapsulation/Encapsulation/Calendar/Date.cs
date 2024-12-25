using System;

namespace Encapsulation.Calendar
{
    public class Date
    {
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        public Date(int month, int day, int year)
        {
            if (IsValidDate(month, day, year))
            {
                Month = month;
                Day = day;
                Year = year;
            }
            else
            {
                Month = 1;
                Day = 1;
                Year = 1970;
            }
        }

        private bool IsValidDate(int month, int day, int year)
        {
            if (month < 1 || month > 12)
                return false;

            if (day < 1 || day > 31)
                return false;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day > daysInMonth[month - 1])
                return false;

            return true;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}