using System;
using System.Data;

namespace calc.SingleArgumentCalcs
{
    public class SqrtCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if (argument < 0)
            {
                throw new Exception("Sqrt of negative number");
            }
            return Math.Sqrt(argument);
        }
    }
}