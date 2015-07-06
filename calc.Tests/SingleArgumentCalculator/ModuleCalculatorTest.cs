using System;

namespace calc.SingleArgumentCalcs
{
    public class ModuleCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}