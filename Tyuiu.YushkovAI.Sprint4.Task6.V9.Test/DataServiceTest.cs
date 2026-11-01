using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint4.Task6.V9.Lib;

namespace Tyuiu.YushkovAI.Sprint4.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void WordCheck()
        {
            string[] array = { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
            Assert.AreEqual(3, ds.Calculate(array));
        }

        [TestMethod]
        public void CheckLengthBoundary()
        {
            string[] array = { "123456", "1234567", "12345678" };
            Assert.AreEqual(1, ds.Calculate(array));
        }
    }
}
