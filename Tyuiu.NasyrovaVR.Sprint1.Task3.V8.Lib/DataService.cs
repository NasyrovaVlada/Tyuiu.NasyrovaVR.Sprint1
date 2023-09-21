using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NasyrovaVR.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double x, double y)
        {
            var res = ((2500 + ((((y / 100) * 2500) / 365) * x)) - 2500);
            return Math.Round(res,2);
        }
    }
}
