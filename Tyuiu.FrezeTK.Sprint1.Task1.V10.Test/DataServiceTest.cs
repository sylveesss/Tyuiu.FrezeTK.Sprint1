using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint1.Task1.V10.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            // Пример: x = 1, y = 3 -> (1 + 3) / (1 + 1) = 4 / 2 = 2
            double x = 1.0;
            double y = 3.0;
            double expected = 2.0;

            double res = DataService.Calculate(x, y);
            Assert.AreEqual(expected, res);
        }
    }
}