﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var numbers = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(int.Parse(input[i]));
            }
            var jumps = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length)
                {
                    break;
                }
                if (numbers[i] != 0)
                {
                    var temp = numbers[i];
                    numbers[i] = 0;
                    i = temp ;
                }
              
                jumps++;

            }
            Console.WriteLine(jumps);
        }
    }
}
