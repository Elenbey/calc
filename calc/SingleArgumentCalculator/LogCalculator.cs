using System;

namespace calc.SingleArgumentCalculator
{
    public class LogCalculator : ISingleArgumentCalculator
    {
        public double Calculate(double argument)
        {
            if(argument == 0)
                throw new Exception("The log of zero does not exist");
            if (argument < 0)
                throw new Exception("The log of negative number does not exist");
            return Math.Log10(argument);
        }
    }
}