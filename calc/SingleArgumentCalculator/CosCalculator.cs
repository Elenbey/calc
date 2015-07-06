using System;

namespace calc.SingleArgumentCalcs
{
    public class CosCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}