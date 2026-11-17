using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Feltölt egy 10 elemű tömböt 100 és 200 közötti egészekkel és kiírja a három legnagyobb
értéket.*/

            int[] szamok = new int[10];
            Random random = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(100,201);
            }
            Console.WriteLine(String.Join(" ",szamok));
            Array.Sort(szamok);
            Array.Reverse(szamok);
            Console.WriteLine($"A három legnagyobb elem: {szamok[0]}, {szamok[1]}, {szamok[2]}");

            Console.ReadKey();
        }
    }
}
