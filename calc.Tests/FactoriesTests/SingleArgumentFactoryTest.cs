using System;
using calc.Factories;
using calc.SingleArgumentCalculator;
using NUnit.Framework;

namespace calc.Tests.FactoriesTests
{
    [TestFixture]
    public  class SingleArgumentFactoryTest
    {
        [TestCase("Module", typeof(ModuleCalculator))]
        [TestCase("Cos", typeof(CosCalculator))]
        [TestCase("Sin", typeof(SinCalculator))]
        [TestCase("Sqrt", typeof(SqrtCalculator))]
        [TestCase("Tan", typeof(TanCalculator))]
        [TestCase("Log", typeof(LogCalculator))]
        [TestCase("Sinh", typeof(SinhCalculator))]
        public  void CreateCalculatorTest(string calculatorName, Type expectedCalculator)
        {
            var calculator = SingleArgumentFactory.CreateCalculator(calculatorName);

            Assert.AreEqual(expectedCalculator, calculator.GetType());
            
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void UnknownCalculatorTest()
        {
            SingleArgumentFactory.CreateCalculator("wrong name");
        }
    }
}