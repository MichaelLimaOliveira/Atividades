﻿using System;
using System.Linq;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(' ')
                                              .Select(number => int.Parse(number))
                                              .ToArray();

            int[] numerosOrdenados = numbers.OrderBy(number => number)
                                            .ToArray();

            foreach (int number in numerosOrdenados)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
