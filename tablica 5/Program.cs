using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] losowatablica = { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9 };
            Console.WriteLine("przed sortowaniem:");
            foreach (int element in losowatablica)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < losowatablica.Length - 1; i++)
            {
                int indeksMin = i;

                for (int j = i + 1; j < losowatablica.Length; j++)
                {
                    if (losowatablica[j] < losowatablica[indeksMin])
                    {
                        indeksMin = j;
                    }
                }
                int temp = losowatablica[i];
                losowatablica[i] = losowatablica[indeksMin];
                losowatablica[indeksMin] = temp;
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

