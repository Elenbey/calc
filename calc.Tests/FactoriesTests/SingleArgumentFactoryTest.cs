using System;
using calc.SingleArgumentCalcs;
using NUnit.Framework;

namespace calc.Factories
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

            Assert.AreEqual(calculator.GetType(), expectedCalculator);
            
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void UnknownCalculatorTest()
        {
            var calculator = SingleArgumentFactory.CreateCalculator("wrong name");
        }
    }
}