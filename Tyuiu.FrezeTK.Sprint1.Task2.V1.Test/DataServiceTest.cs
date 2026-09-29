using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint1.Task2.V1.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckConvertKmToMilesValid()
        {
            int km = 10;
            double expected = 6.215;

            double res = DataService.ConvertKmToMiles(km);
            Assert.AreEqual(expected, res);
        }
    }
}