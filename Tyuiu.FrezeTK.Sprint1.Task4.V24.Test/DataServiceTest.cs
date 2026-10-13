using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint1.Task4.V24.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            // Тестируем новые параметры, которые подходят под формулу робота
            double x = 4.0;
            double y = 3.0;

            double res = ds.Calculate(x, y);
            double wait = 0.248; // ln(12) / (4 + 2 * 3) = 2.4849 / 10 = 0.248

            Assert.AreEqual(wait, res);
        }
    }
}
