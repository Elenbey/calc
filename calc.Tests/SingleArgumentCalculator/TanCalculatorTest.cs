using System;

namespace calc.SingleArgumentCalcs
{
    public class TanCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}