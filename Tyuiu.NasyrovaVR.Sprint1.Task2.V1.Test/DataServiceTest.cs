using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint1.Task2.V1.Lib;

namespace Tyuiu.NasyrovaVR.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3218;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(2000, res);
        }
    }
}
