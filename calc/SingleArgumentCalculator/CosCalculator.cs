using System;

namespace calc.SingleArgumentCalculator
{
    /// <summary>
    /// operation cos
    /// </summary>
    
    public class CosCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}