using calc.SingleArgumentCalculator;
using NUnit.Framework;

namespace calc.Tests.SingleArgumentCalculatorTests
{
    [TestFixture]
    public class TanCalculatorTest
    {
        [TestCase(1, 1.557, 0.001)]
        [TestCase(0.1, 0.100, 0.001)]
        [TestCase(4,1.157, 0.001)]
        [TestCase(0.5, 0.546, 0.001)]
        [TestCase(0, 0, 1.0)]
        [TestCase(-0.1, -0.100, 0.001)]
        [TestCase(-4, -1.157, 0.001)]
        


        public void CalculateTest(double argument, double result, double accuracy)
        {
            var calculator = new TanCalculator();
            var testResult = calculator.Calculate(argument);

            Assert.AreEqual(testResult, result, accuracy);

        }


       

    }

}