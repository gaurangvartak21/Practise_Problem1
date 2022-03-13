using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tossnumber = 100;
            int heads = 0;
            int tails = 0;
            while (tossnumber > 0)
            {
                Random rnd = new Random();
                int result = rnd.Next(0,2);
                if (result == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
                tossnumber--;   
            }
            Console.WriteLine("total heads = " + heads);
            Console.WriteLine("total tails = " +tails);

            Console.ReadKey();
        }
    }
}
