using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());
            bool LeapYear = Program.LeapYear(year);
            if (LeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
        public static bool LeapYear( int year)
        {
            if((year%400==0) || (year%100!=0 && year%4==0))
                {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
