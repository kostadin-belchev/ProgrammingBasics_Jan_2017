﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Numer_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            if (input < 100)
            {
                Console.WriteLine("Less than 100");
            }else
            if (input >= 100 && input <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }else
            if (input > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
