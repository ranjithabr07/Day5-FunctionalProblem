﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunProblem
{
    internal class PowerOfTwoProblem
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter a number");
            int Number = Convert.ToInt32(Console.ReadLine());

            while (Number < 0 || Number >= 31)
            {
                Console.Write("Please enter a valid number : ");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Power of two is: " + Math.Pow(2, i));
            }
        }
    }
}
