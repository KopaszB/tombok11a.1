using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Feltölt egy 10 elemű tömböt 1 és 100 közötti egészekkel és kiírja az átlagot meghaladó értékeket.*/
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,101);
            }
            Console.WriteLine(String.Join(" ",szamok));
            double atlag = szamok.Average();
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]>atlag)
                {
                    Console.Write(szamok[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
