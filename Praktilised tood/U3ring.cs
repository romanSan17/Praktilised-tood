using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_tood
{
    public class U3ring
    {
        public static int IosifProblem(int p, int m)
        {
            // Inimeste nimekirja koostamine ; Создаение списка людей 
            List<int> people = new List<int>();
            for (int i = 1; i <= p; i++)
            {
                people.Add(i);
            }

            int nowIndex = 0;

            while (people.Count > 1)
            {
                // Kõrvalekalde määratlus ; Определение выбывшего человека
                nowIndex = (nowIndex + m - 1) % people.Count;

                // kustuta
                people.RemoveAt(nowIndex);
            }

            // viimane ellujäänu ; последний выживший
            return people[0];
        }
    }
}
