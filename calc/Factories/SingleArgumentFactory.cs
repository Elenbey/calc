using System;
using calc.SingleArgumentCalculator;

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

                case "Sqrt":
                    return new SqrtCalculator();

                case "Tan":
                    return new TanCalculator();

                case "Log":
                    return new LogCalculator();

                case "Sinh":
                    return new SinhCalculator();

                default:
                    throw new Exception("Unknown calculator");
            }
        }
    }
}