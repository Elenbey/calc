using System;
using calc.SingleArgumentCalcs;

namespace calc.Factories
{
    public static class SingleArgumentFactory
    {
        public static ISingleArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Module":
                    return new ModuleCalculator();

                case "Cos":
                    return new CosCalculator();

                case "Sin":
                    return new SinCalculator();
                default:
                    throw new Exception("Unknown calculator");
            }
        }
    }
}