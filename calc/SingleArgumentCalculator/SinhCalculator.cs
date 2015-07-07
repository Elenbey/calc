using System;

namespace calc.SingleArgumentCalcs
{
    public class SinhCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sinh(argument);
        }
    }
}