using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_tood
{
    public class U1maxmin
    {
        public static double erinevus(double[] array)
        {
            double max = array[0];
            double min = array[0];

            foreach (var num in array)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            return max - min;
        }
    }
}
