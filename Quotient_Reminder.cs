using System;

namespace Quotient_reminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reminder(25, 2));
            Console.WriteLine(Quotient(24, 2));
        }
        public static int Reminder(int divident, int diviosor)
        {
            int result = divident % diviosor;
            return result;
        }
        public static int Quotient(int divident, int diviosor)
        {
            int result = divident / diviosor;
            return result;
        }
    }
}
