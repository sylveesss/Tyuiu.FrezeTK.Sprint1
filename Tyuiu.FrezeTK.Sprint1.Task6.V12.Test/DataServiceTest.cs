using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FrezeTK.Sprint1.Task6.V12.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckLastWordRepetition()
        {
            DataService ds = new DataService();
            string text = "тест это просто обычный тест";
            bool res = ds.CheckLastWordRepetiton(text);


            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
