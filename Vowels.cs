
using System;

namespace Vovels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet");
            string input = Console.ReadLine();
            char alphabet = input[0];
            switch(alphabet)
            {
                 case 'a':Console.WriteLine("is a vowel");
                    break;
                 case 'e':Console.WriteLine("is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("is a vowel");
                    break;
                default:Console.WriteLine(" is a Consonant");
                    break ;
            }
        }
    }
}
