using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Pokaz1(int[] tabo, int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write(tabo[i] + " ");
            }
        }

        static void Pokaz2(int[,] tabo, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(tabo[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int kolumna = 3;
            int wiersz = 3;
            int[,] tab = {{3,4,9},
                          {2,5,8},
                          {1,6,7,}};

            int[] dod = new int[kolumna * wiersz];

            int i, j, k;
            int max;
            int indx;

            Console.WriteLine("Tablica wprowadzona z poziomu kodu:");
            Pokaz2(tab, wiersz, kolumna);

            k = 0;
            for (i = 0; i < wiersz; i++)
            {
                for (j = 0; j < kolumna; j++)
                {
                    dod[k] = tab[i, j];
                    k++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine();


            for (i = 0; i < k; i++)
            {
                max = dod[i];
                indx = i;
                for (j = i; j < k; j++)
                {
                    if (dod[j] > max)
                    {
                        max = dod[j];
                        indx = j;
                    }
                }
                dod[indx] = dod[i];
                dod[i] = max;

            }

            k = 0;
            for (i = 0; i < wiersz; i++)
            {
                for (j = 0; j < kolumna; j++)
                {
                    tab[i, j] = dod[k];
                    k++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tablica posortowana:");
            Pokaz2(tab, wiersz, kolumna);

            Console.ReadKey();
        }
    }
}
