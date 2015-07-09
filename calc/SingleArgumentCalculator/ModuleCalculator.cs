using System;

namespace calc.SingleArgumentCalculator
{
    /// <summary>
    /// operation abs
    /// </summary>
    

    public class ModuleCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}