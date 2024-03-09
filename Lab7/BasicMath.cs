using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class BasicMath
    {
        //no attributes
        //defaut constructor
        //methods
        public double Addition(double x, double y)
        { 
            return x + y; 
        }
        public double Subtraction(double x, double y)
        { 
            return x - y; 
        }
        public double Multiplication(double x, double y)
        {
            return x * y; 
        }
        public double Division(double x, double y)
        {
            if (y == 0)
            { 
                //does not allow to divide by zero
                throw new ArgumentException("Cannot divide by 0", nameof(y));
            }
            else
            { 
                return x / y; 
            }
        }
    }
}
