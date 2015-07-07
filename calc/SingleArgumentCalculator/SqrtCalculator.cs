using System;

namespace calc.SingleArgumentCalcs
{
    public class SqrtCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sqrt(argument);
        }
    }
}