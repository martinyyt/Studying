﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Variations
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] variation;

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop==numberOfLoops)
            {
                for (int i = 0; i < numberOfLoops; i++)
                {
                    Console.Write("{0,4}",variation[i]);
                }
                Console.WriteLine();
                return;
            }

            for (int i = 1; i <= numberOfIterations; i++)
            {
                variation[currentLoop] = i;
                NestedLoops(currentLoop+1);
            }
        }

        static void Main(string[] args)
        {
            numberOfLoops = int.Parse(Console.ReadLine());
            numberOfIterations = int.Parse(Console.ReadLine());
            variation = new int[numberOfLoops];

            NestedLoops(0);

        }
    }
}
