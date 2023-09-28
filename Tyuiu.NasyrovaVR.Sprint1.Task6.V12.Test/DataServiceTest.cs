using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint1.Task6.V12.Lib;

namespace Tyuiu.NasyrovaVR.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "собака лошадь собака";
            DataService ds = new DataService();
            bool res = ds.CheckLastWordRepetiton(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
