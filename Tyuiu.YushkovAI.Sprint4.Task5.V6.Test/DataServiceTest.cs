using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task5.V6.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ReplacePositiveNum()
        {
            int[,] array = { { -3, -2, -1, 0, 1 }, { 2, 3, 4, 5, -3 },
                             { 0, 5, -1, 4, -2 }, { 3, -3, 2, 0, 1 },
                             { -1, 4, -2, 5, 0 } };
            int[,] expected = { { -3, -2, -1, 0, 1 }, { 1, 1, 1, 1, -3 },
                                { 0, 1, -1, 1, -2 }, { 1, -3, 1, 0, 1 },
                                { -1, 1, -2, 1, 0 } };
            CollectionAssert.AreEqual(expected, ds.Calculate(array));
        }

        [TestMethod]
        public void CheckWithoutPositiveNum()
        {
            int[,] array = { { -3, 0, -1 }, { 0, -2, -3 } };
            int[,] expected = { { -3, 0, -1 }, { 0, -2, -3 } };
            CollectionAssert.AreEqual(expected, ds.Calculate(array));
        }
    }
}
