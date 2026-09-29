using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FrezeTK.Sprint1.Task0.V19.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateExpressionValid()
        {
            double res = DataService.CalculateExpression();
            Assert.AreEqual(10.0, res);
        }
    }
}