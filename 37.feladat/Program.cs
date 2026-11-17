using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*egy tízelemű tömböt feltölt számokkal -50 és +50 között, majd megszámolja a negatív, pozitív
és nulla értékeket*/
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(-50,51);
            }
            Console.WriteLine(String.Join("  ",szamok));

            int pozDb = 0;
            int negDb = 0;
            int nullDb = 0; 
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]>0)
                {
                    pozDb++;
                }
                else if (szamok[i] < 0)
                {
                    negDb++;
                }
                else
                {
                    nullDb++;   
                }
            }
            Console.WriteLine($"Pozitív számok: {pozDb} db");
            Console.WriteLine($"Negatív számok: {negDb} db");
            Console.WriteLine($"nullák: {nullDb} db");
            Console.ReadKey();
        }
    }
}
