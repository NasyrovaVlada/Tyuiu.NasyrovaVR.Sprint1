using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint1.Task5.V1.Lib;

namespace Tyuiu.NasyrovaVR.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 3;
            double x2 = 4;
            double y2 = 6;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(4, result);





        }
    }
}
