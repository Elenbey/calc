using System;

namespace calc.SingleArgumentCalculator
{
    public class ModuleCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}