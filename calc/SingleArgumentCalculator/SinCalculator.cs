using System;

namespace calc.SingleArgumentCalculator
{
    public class SinCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}