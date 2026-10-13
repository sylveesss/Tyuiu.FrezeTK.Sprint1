using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint1.Task0.V19.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate();
            double wait = 10.0;
            Assert.AreEqual(wait, res);
        }
    }

} 