﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i <= n - 1; i++)
            {
                var N = int.Parse(Console.ReadLine());
                if (N < min)
                {
                    min = N;
                }
            }
            Console.WriteLine(min);
        }
    }
}
