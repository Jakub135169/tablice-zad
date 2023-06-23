using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] losowatablica = new int[10];
            string[] wartości = { "los1", "los2", "los3", "los4", "los5", "los6", "los7", "los8", "los9", "los10" };
            for (int i = 0; i < wartości.Length; i++)
            {
                Console.WriteLine(wartości[i]);
                Console.ReadKey();

            }
            Console.WriteLine("Druga pętla:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("odwrócenie" + wartości[i]);

                Console.ReadKey();
            }
        }
    }
}
