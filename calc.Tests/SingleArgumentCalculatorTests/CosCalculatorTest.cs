using calc.SingleArgumentCalculator;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalculatorTests
{
    [TestFixture]
    public class CosCalculatorTest
    {
        [TestCase(0, 1,1.0)]
        [TestCase(0.1, 0.995,0.001)]
        [TestCase(0.5, 0.877,0.001)]
        [TestCase(1, 0.540,0.001)]
        [TestCase(-0.1, 0.995, 0.001)]
        [TestCase(-0.5, 0.877, 0.001)]

        public void CalculateTest(double argument, double result,double accuracy)
        {
            var calculator = new CosCalculator();
            var testResult = calculator.Calculate(argument);
           
            Assert.AreEqual(testResult, result, accuracy);

        }
    }
}