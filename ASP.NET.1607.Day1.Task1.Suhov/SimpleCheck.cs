using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day1.Task1.Suhov
{
    public static class SimpleCheck
    {
        /// <summary>Checking whether number is simple</summary> 
        /// <param name="value">Number which should be checked</param> 
        /// <returns>If the number <paramref name="n"/> is simple, result:(<paramref name="value"/>) will be true</returns> 
        public static bool IsSimple(int numb)
        {
            for (int i = 2; i < numb; i++)
            {
                if (numb % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
