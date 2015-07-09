using System;

namespace calc.SingleArgumentCalculator
{
    /// <summary>
    /// operation sinh
    /// </summary>
    

    public class SinhCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sinh(argument);
        }
    }
}