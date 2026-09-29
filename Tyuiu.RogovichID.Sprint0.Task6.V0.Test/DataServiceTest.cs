using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.RogovichID.Sprint0.Task6.V0.Lib;

namespace Tyuiu.RogovichID.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] {1, 2, 3, 4, 5};
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
