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
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            var res = ((startAmount + ((((percent / 100) * startAmount) / 365) * timeDays)) - startAmount);
            return Math.Round(res, 3);
        }
    }
}
