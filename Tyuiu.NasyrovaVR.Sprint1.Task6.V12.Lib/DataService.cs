using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;


namespace Tyuiu.NasyrovaVR.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            if ((int)value.LastIndexOf(' ') == (int)value.IndexOf((string)value.Substring((int)value.LastIndexOf(' '))))
            { 
                 return (bool)true;
            }
            else
            {
                 return (bool)false;
            }
        }
            
    }
}
