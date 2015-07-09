using calc.Sortes;
using NUnit.Framework;

namespace calc.Tests.ArraySortesTests
{
    [TestFixture]
    public abstract class AbstractSortTest
    {
        protected ISort Sorter;

        [TestCase(new double[] {1, 0 , 6 , 1.1 , 4 , 0 , -1},new double[] {-1, 0, 0, 1, 1.1 , 4, 6})]
        [TestCase(new double[] { 3, 0, 0, 5.5, -1, 0, 2 }, new double[] {-1, 0, 0, 0, 2, 3, 5.5 })]
        [TestCase(new double[] { 4, 4, 4}, new double[] { 4,4,4 })]
        [TestCase(new double[] { 0, 0, -10 }, new double[] { -10, 0, 0 })]
        [TestCase(new double[] { 1, 4, 0, 8, 15, 4, 5, 9, 7, 9, 5, 6, 4, 7, 9, 8, 6, 7, -5, -4, -3, -4, 1000, 10.234, 10.235 }, new double[] { -5, -4, -4, -3, 0, 1, 4, 4, 4, 5, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 9, 10.234, 10.235 , 15, 1000 })]
        [TestCase(new double[] { 0, 1, 1000 }, new double[] { 0, 1, 1000 })]
        public void SortTest(double[] arrayToSort, double[] result)
        {
            var testResult = Sorter.Sort(arrayToSort);
            Assert.AreEqual(testResult, result);
        }
    }
}