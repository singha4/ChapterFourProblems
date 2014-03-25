using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input;
            int n;
            while(true)
            {
                Console.WriteLine("Enter a number");
                input = Console.ReadLine();
                n = Convert.ToInt32(input);

                if (input == "999")
                {
                    break;
                }

                if (n < 999)
                {
                    sum += n;
                }
                Console.WriteLine("The sum is {0}",sum);
            }
        }
    }
}
