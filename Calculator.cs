﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int x, int y) => x+y;
        public int Subtract(int a , int b) => a-b;
        public int Multiply(int a , int b) => a*b;

        public int Division(int a , int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }

    }
}
