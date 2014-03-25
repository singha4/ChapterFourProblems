using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class GetVowel
    {
        static void Main(string[] args)
        {

            int sum = 0;
            string input;
            int vowel;
            while (true)
            {
                Console.WriteLine("Enter a vowel");
                input = Console.ReadLine();

                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("OK");
                }
            }
        }
    }
}
