using calc.SingleArgumentCalculator;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalculatorTests
{
    [TestFixture]
    public class SinhCalculatorTest
    {
        [TestCase(0, 0, 1.0)]
        [TestCase(0.1, 0.100, 0.001)]
        [TestCase(0.5, 0.521, 0.001)]
        [TestCase(1, 1.175, 0.001)]
        [TestCase(-0.1, -0.100, 0.001)]
        [TestCase(-0.5, -0.521, 0.001)]
        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new SinhCalculator();
            var testResult = calculator.Calculate(argument);

            Assert.AreEqual(result, testResult, accuracy);

        }
    }
}