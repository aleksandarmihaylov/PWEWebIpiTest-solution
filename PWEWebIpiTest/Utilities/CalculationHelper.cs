using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWEWebIpiTest.Utilities
{
    public class CalculationHelper
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Devision(int a, int b)
        {
            if(a > 0 && b > 0)
            {
                return a / b;

            }
            else
            {
                return 0;
            }
        }
    }
}