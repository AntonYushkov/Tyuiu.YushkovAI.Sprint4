using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task1.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ProductOddNum()
        {
            int[] array = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };
            Assert.AreEqual(2205, ds.Calculate(array));
        }

        [TestMethod]
        public void CheckNegativeOddNum()
        {
            int[] array = { -3, 2, 5 };
            Assert.AreEqual(-15, ds.Calculate(array));
        }
    }
}
