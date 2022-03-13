using System;

namespace Harmonic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value=HarmonicNumber(4);
            Console.WriteLine(value);   
        }
        public static double HarmonicNumber(int n)
        {
            double result = 1;
            for (double i = 1; i < n; i++) 
            {
                result= result + (1/i);
            }
            return result;
        }
    }
}
