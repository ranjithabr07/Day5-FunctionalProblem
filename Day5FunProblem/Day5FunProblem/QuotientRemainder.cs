﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunProblem
{
    internal class QuotientRemainder
    {
        public void QuotientAndRemainder()
        {
            Console.Write("Enter the Dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }
}
