using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint1.Task4.V13.Lib;

namespace Tyuiu.NasyrovaVR.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);

        }
    }
}
