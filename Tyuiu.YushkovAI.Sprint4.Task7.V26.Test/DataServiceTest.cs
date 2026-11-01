using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task7.V26.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckProductNumMatrix()
        {
            int rows = 5;
            int columns = 3;
            string value = "351268459614723";
            int res_wait = 18432;
            int res = ds.Calculate(rows, columns, value);
            Assert.AreEqual(res_wait, res);
        }

        [TestMethod]
        public void CheckZeroEvenNum()
        {
            Assert.AreEqual(0, ds.Calculate(2, 3, "123405"));
        }
    }
}
