using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_calculator
{
    internal abstract class CalculatorBase
    {
        // Method to add two integers
        public abstract float Add(float a, float b);

        // Method to subtract two integers
        public abstract float Subtract(float a, float b);

        // Method to multiply two integers
        public abstract float Multiply(float a, float b);
    }
}
