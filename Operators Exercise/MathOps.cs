﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Exercise
{
    internal class MathOps
    {
        public static int Add(int num1, int num2)
        { return num1 + num2; }

        public static int Subtract(int num1, int num2)
        { return num1 - num2; }

        public static int Multiply(int num1, int num2)
        { return num1 * num2; }

        public static int Divide(int num1, int num2)
        { return num1 / num2; }

        public static int Modulus(int num1, int num2)
        { return num1 % num2; }
    }

    internal class Circle
    {
       public static double AreaOfCircle(double radius)
        {
           return Math.PI * Math.Pow(radius, 2);
        }

            
    }

}

