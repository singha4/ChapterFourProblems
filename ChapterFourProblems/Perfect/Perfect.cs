using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Perfect
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int sum = 0;

                for (int n = 1; n < i; n++)
                {
                    
                    if (i % n == 0)
                    {
                        sum = sum + n;
                    }
                    
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
