﻿using System;

namespace MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nTABLA DE MULTIPLICAR DEL {0}", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                }
            }










        }
    }
}