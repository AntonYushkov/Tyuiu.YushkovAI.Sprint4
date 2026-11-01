using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task4.V19.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void SumOddNumMatrix()
        {
            int[,] array = { { 6, 7, 3, 5, 1 }, { 6, 5, 2, 2, 7 },
                             { 2, 6, 4, 6, 6 }, { 7, 5, 5, 2, 6 },
                             { 3, 1, 5, 7, 7 } };
            Assert.AreEqual(68, ds.Calculate(array));
        }

        [TestMethod]
        public void CheckNegativeOddNum()
        {
            int[,] array = { { -3, 2, 5 }, { 4, -7, 0 } };
            Assert.AreEqual(-5, ds.Calculate(array));
        }
    }
}
