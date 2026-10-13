using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint1.Task5.V7.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double f = 45.0;
            int res = ds.AngleToHoursMinutes(f);
            int wait = 1;    // Ожидаем 1 полный час

            Assert.AreEqual(wait, res);
        }
    }
}
