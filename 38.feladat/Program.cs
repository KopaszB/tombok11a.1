using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Feltölt egy 10 elemű tömböt 200 és 300 közötti egészekkel és kiírja, ezek közöl hányadik a legnagyobb. 
             */
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(200, 301);
            }
            Console.WriteLine(String.Join(" ",szamok));

            int maximum = szamok[0];
            int maxIndex = 0;
            int minimum = szamok[0];
            int minIndex = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]>maximum)
                {
                    maximum = szamok[i];
                    maxIndex = i;
                }
                if (szamok[i] < minimum)
                {
                    minimum = szamok[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {maximum} és a {maxIndex+1}-dik helyen áll.");
            Console.WriteLine($"A legkisebb szám: {minimum} és a {minIndex+1}-dik helyen áll.");


            Console.ReadKey();
        }
    }
}
