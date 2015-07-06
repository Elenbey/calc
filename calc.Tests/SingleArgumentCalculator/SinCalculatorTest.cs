using System;

namespace calc.SingleArgumentCalcs
{
    public class SinCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}