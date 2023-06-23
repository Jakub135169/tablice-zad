using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] losowatablica = { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9 };
                Console.WriteLine("przed sortowaniem:");

                foreach (int element in losowatablica)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();


                for (int i = 1; i < losowatablica.Length; i++)
                {
                    int obecnyElement = losowatablica[i];
                    int j = i - 1;

                    while (j >= 0 && losowatablica[j] > obecnyElement)
                    {
                        losowatablica[j + 1] = losowatablica[j];
                        j--;
                    }

                    losowatablica[j + 1] = obecnyElement;
                }

                Console.WriteLine("po sortowaniu:");
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


        

