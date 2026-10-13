using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint1.Task1.V10.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 1.0;
            double res = ds.Calculate(x, y);
            double wait = 1.0;

            Assert.AreEqual(wait, res);
        }
    }
}