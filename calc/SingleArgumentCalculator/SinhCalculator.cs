using System;

namespace calc.SingleArgumentCalculator
{
    public class SinhCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sinh(argument);
        }
    }
}