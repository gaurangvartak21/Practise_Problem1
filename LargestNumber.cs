using System;

namespace Largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 13;
            int num3 = 17;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest " + num1);
                }
                else
                {
                    Console.Write("Number three is the largest " + num3);
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest " + num2);
            else
                Console.Write("Number three is the largest " + num3);
        }
    }


}        
    

