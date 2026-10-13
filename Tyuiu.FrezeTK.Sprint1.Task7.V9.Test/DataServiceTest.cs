using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint1.Task7.V9.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;

            double res = ds.Calculate(x, y);
            double wait = 0.875;

            Assert.AreEqual(wait, res);
        }
    }
}
