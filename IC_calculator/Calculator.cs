using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IC_calculator
{
    internal class Calculator : CalculatorBase
    {
        // Override Add method
        public override float Add(float a, float b) => a + b;
       
        // Override Subtract method
        public override float Subtract(float a, float b) => a - b;

        // Override Multiply method
        public override float Multiply(float a, float b) => a * b;

        public float Valid(string? s)
        {
            float number;
            while ((s == null) || !float.TryParse(s, out number))
            {
                Console.WriteLine($" Invalid data: {s}, enter again ");
                s = Console.ReadLine();
            }
            return number;
        }
    }
}
