using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint1.Task7.V9.Lib;

namespace Tyuiu.FrezeTK.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            double x = 0;
            double y = 0;
            double res = DataService.Calculate(x, y);
            Assert.IsNotNull(res);
        }
    }
}
