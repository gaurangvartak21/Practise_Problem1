using System;

namespace swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 97;
            int j = 42;
            Console.WriteLine("I and J " + i + " and " +j);
            int temp = i;
            i = j;
            j = temp;
            Console.WriteLine("I and J " + i + " and " + j);
        }
    }
}
