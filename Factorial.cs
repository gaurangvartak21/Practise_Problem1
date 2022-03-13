using System;

namespace Factorial
{
    internal class Program
    {
        public static void Main()
        {
            Program p = new Program();
            int fact = 0;
            fact=p.Factorial(8);
            Console.WriteLine(fact);
            Console.ReadKey();
        }
        public  int Factorial(int num)
        {
            int result = 1;
            
            while (num>0)
            {
                result=result*num;
                num--;
            }
           return result;   
        }
    }
}
