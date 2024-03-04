using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class BasicMath
    {
        public double Addition(double x, double y)
        { return x + y; }
        public double Subtraction(double x, double y)
        { return x - y; }
        public double Multiplication(double x, double y)
        { return x * y; }
        public double Division(double x, double y)
        {
            if (y == 0)
            { return 0; }
            else
            { return x / y; }
        }
    }
}
