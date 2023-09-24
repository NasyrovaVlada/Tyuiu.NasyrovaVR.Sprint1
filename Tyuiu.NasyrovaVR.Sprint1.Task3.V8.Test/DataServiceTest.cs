using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint1.Task3.V8.Lib;

namespace Tyuiu.NasyrovaVR.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            double startAmount = 2500;
            double percent = 20;
            double timeDays = 30;
            
            double wait = 41.096;
            var res = ds.IncomeAmount(startAmount, percent, timeDays);
            Assert.AreEqual(wait, res);
        }
    }
}
