using System;

namespace calc.SingleArgumentCalculator
{
    /// <summary>
    /// operation tan
    /// </summary>
    

    public class TanCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}