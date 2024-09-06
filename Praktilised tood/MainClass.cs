using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktilised_tood
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //3

            int p = 10; // inimesed
            int m = 3; 
            int survivor = U3ring.IosifProblem(p, m);
            Console.WriteLine($"mees numbriga jäi ellu: {survivor}");

            //2

            int[] randomArray;
            int countInRange = U2massiv.massivNumbr(out randomArray);

            Console.WriteLine("massiv: " + string.Join(", ", randomArray));
            Console.WriteLine($"sisestatud numbrid vahemikus 0 kuni 125: {countInRange}");

            //1

            double[] array = { 3.5, 7.2, -1.4, 5.9 };
            double difference = U1maxmin.erinevus(array);

            Console.WriteLine($"Maksimaalse ja minimaalse arvu vahe: {difference}");
        }
    }
}