using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task0.V5.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckEvenNum()
        {
            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            Assert.AreEqual(24, ds.GetSumEvenArrEl(array));
        }

        [TestMethod]
        public void CheckNegativeEvenNum()
        {
            int[] array = { -4, -3, 0, 2 };
            Assert.AreEqual(-2, ds.GetSumEvenArrEl(array));
        }
    }
}
