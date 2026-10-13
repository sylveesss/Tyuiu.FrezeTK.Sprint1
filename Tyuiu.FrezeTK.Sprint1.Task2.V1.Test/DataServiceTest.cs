using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint1.Task2.V1.Lib;
namespace Tyuiu.FrezeTK.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertKmToMiles()
        {
            DataService ds = new DataService();
            int km = 16;

            double res = ds.ConvertKmToM(km);
            double wait = 9.944; 

            Assert.AreEqual(wait, res);
        }
    }
}