using System;

namespace calc.SingleArgumentCalculator
{
    public class TanCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}