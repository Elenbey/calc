using System;

namespace calc.SingleArgumentCalcs
{
    public class LogCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}