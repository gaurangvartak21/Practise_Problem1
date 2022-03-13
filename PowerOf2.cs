using System;

namespace PowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = PowerOf2 (7);
            Console.WriteLine(value);
        }
        public static int PowerOf2(int power)
        {
            int result=1;
            while(power > 0)
            {
                result=result*2;
                power--;
            }
            return result;
        }
    }
}
