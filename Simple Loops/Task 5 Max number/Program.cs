﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
               int num = int.Parse(Console.ReadLine());

                if (num >= maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
