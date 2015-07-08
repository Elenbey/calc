using calc.SingleArgumentCalculator;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalculatorTests
{
    [TestFixture]
    public class ModuleCalculatorTest
    {
        [TestCase(-5, 5)]
        [TestCase(7, 7)]
        [TestCase(0,0)]
        public void Calculate(double argument, double result)
        {
            var calculator = new ModuleCalculator();
            var testResult = calculator.Calculate(argument);
            

            Assert.AreEqual(testResult,result);
        }
    }
}