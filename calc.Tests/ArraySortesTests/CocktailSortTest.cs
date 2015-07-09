using calc.Sortes;
using NUnit.Framework;

namespace calc.Tests.ArraySortesTests
{
    [TestFixture]
    public class CocktailSortTest : AbstractSortTest
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new CocktailSort();
        }
    }
}