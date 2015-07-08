using System;

namespace calc.SingleArgumentCalculator
{
    public class LogCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if(argument == 0)
                throw new Exception("LogNull");
            if (argument < 0)
                throw new Exception("LogNegative");
            return Math.Log10(argument);
        }
    }
}