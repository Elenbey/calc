using calc.Sortes;
using NUnit.Framework;

namespace calc.Tests.ArraySortesTests
{
    [TestFixture]
    public class BubbleSortTest: AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new BubbleSort();
        }
    }
}