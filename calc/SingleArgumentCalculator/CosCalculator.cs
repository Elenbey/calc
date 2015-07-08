using System;

namespace calc.SingleArgumentCalculator
{
    
    public class CosCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}