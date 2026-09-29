using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.RogovichID.Sprint0.Task2.V0.Lib;
namespace Tyuiu.RogovichID.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создание методов тестирование, методов из библиотеки
            var name = "Иван";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Иван", res);
        }
    }
}
