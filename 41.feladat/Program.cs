using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1, 50);
            }
            Console.Write("A tömb elemei: ");
            Console.WriteLine(String.Join(" ", szamok));

            Console.WriteLine($"Összeg: {szamok.Sum()}");
            Console.WriteLine($"Átlag: {szamok.Average()}");
            long szorzat = 1;
            for (int i = 0; i < szamok.Length; i++)
            {
                szorzat = szorzat * szamok[i];
            }
            Console.WriteLine($"Szorzat: {szorzat}");


            Console.ReadKey();
        }
    }
}
