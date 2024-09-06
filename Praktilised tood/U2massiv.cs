using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_tood
{
    public class U2massiv
    {
        public static int massivNumbr(out int[] array)
        {
            Random random = new Random();

            int k = random.Next(5, 21);
            array = new int[k];

            for (int i = 0; i < k; i++)
            {
                array[i] = random.Next(-100, 201); 
            }
            //Vahemikule vastavate elementide arvu loendamine ; Подсчет количества элементов подходящих под диапозон
            int count = 0;
            foreach (var num in array)
            {
                if (num > 0 && num < 125)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
