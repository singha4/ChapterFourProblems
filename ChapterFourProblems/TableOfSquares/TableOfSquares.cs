﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares
{
    class TableOfSquares
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                sum = i * i;
                Console.WriteLine("The number: {0} is {1} squared ", i, sum);
            }
        }
    }
}
