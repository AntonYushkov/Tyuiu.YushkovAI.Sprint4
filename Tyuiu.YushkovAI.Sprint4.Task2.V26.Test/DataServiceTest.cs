using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task2.V26.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ProductOddNum()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6 };
            Assert.AreEqual(1575, ds.Calculate(array));
        }

        [TestMethod]
        public void CheckWithoutOddNum()
        {
            int[] array = { 2, 4, 6, 8 };
            Assert.AreEqual(1, ds.Calculate(array));
        }
    }
}
