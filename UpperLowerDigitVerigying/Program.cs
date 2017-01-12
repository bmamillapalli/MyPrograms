using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerDigitVerigying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Character which you want to check:");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            if (c >= 'a' && c <= 'z')
            {
                if (c == 'a' && c == 'e' && c == 'i' && c == 'o' && c == 'u')
                    Console.WriteLine("It is a Lowercase Vowel.");
                else
                    Console.WriteLine("It is a Lowercase Consonant.");
            }
            else if (c >= 'A' && c <= 'Z')
            {
                if (c == 'A' && c == 'E' && c == 'I' && c == 'O' && c == 'U')
                    Console.WriteLine("It is a Uppercase Vowel.");
                else
                    Console.WriteLine("It is a Uppercase Consonant.");
            }
            else if (c >= '0' && c <= '9')
                Console.WriteLine("THis is a Number Digit.");
            else
                Console.WriteLine("This may be another UNicode.");

            Console.Read();

        }
    }
}
