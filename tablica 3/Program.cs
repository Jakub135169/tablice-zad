using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            {
                int[] losowatablica = { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9 };
                Console.Write(losowatablica[0]);
                foreach (int element in losowatablica)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();


                for (int i = 0; i < losowatablica.Length - 1; i++)
                {
                    for (int j = 0; j < losowatablica.Length - 1 - i; j++)
                    {
                        if (losowatablica[j] > losowatablica[j + 1])
                        {

                            int temp = losowatablica[j];
                            losowatablica[j] = losowatablica[j + 1];
                            losowatablica[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Tablica po sortowaniu:");
                foreach (int element in losowatablica)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }
}
