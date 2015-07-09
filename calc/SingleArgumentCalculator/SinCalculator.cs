using System;

namespace calc.SingleArgumentCalculator
{
    /// <summary>
    /// operation sin
    /// </summary>
    

    public class SinCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}