﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiSFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    
                    int result = i * j;
                    Console.Write($"{i} * {j} = {result}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
