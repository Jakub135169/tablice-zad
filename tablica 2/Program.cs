using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] losowatablica = { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9 };
                Console.Write(losowatablica[0]);
                Console.ReadKey();

                int największy = losowatablica[0];
                int najmniejszy = losowatablica[0];
                for (int i = 1; i < losowatablica.Length; i++)
                {
                    if (losowatablica[i] < najmniejszy)
                    {
                        najmniejszy = losowatablica[i];
                    }

                    if (losowatablica[i] > największy)
                    {
                        największy = losowatablica[i];
                    }
                }

                Console.WriteLine("Najmniejszy  " + najmniejszy);
                Console.WriteLine("Największy " + największy);
                Console.ReadKey();
            }
        }
    }
}
