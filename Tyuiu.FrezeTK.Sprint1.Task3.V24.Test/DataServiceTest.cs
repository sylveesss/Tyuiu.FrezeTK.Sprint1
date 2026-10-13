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
            double x = 5.0;
            double y = 2.0;

            double res = ds.Calculate(x, y);
            double wait = 0.294;

            Assert.AreEqual(wait, res);
        }
    }
}
