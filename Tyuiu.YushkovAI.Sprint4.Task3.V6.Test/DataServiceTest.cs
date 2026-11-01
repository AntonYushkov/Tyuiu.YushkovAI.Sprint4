using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task3.V6.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void MaxNumSecondRow()
        {
            int[,] array = { { 8, 8, 3, 4, 5 }, { 8, 6, 6, 4, 6 },
                             { 3, 6, 5, 3, 4 }, { 5, 6, 3, 7, 5 },
                             { 7, 8, 5, 6, 6 } };
            Assert.AreEqual(8, ds.Calculate(array));
        }

        [TestMethod]
        public void CheckOnlySecondRow()
        {
            int[,] array = { { 99, 98, 97 }, { -7, -2, -5 }, { 50, 60, 70 } };
            Assert.AreEqual(-2, ds.Calculate(array));
        }
    }
}
