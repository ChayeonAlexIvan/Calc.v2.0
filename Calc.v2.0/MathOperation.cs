using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.v2._0
{
    class MathOperation
    {
        public static string Addition (string num1, string num2)
        {
            double a;
            double b;
            if((!Double.TryParse(num1, out a)) || (!Double.TryParse(num2, out b)))
            {
                return null;
            }
            return (a + b).ToString();
        }
        public static string Subtraction(string num1, string num2)
        {
            double a;
            double b;
            if ((!Double.TryParse(num1, out a)) || (!Double.TryParse(num2, out b)))
            {
                return null;
            }
            return (a - b).ToString();
        }

        public static string Multiplication(string num1, string num2)
        {
            double a;
            double b;
            if ((!Double.TryParse(num1, out a)) || (!Double.TryParse(num2, out b)))
            {
                return null;
            }
            return (a * b).ToString();
        }

        public static string Division(string num1, string num2)
        {
            double a;
            double b;
            if ((!Double.TryParse(num1, out a)) || (!Double.TryParse(num2, out b)))
            {
                return null;
            }
            return (a / b).ToString();
        }
    }
}
