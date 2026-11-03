using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraiFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        { /*1. Hozz létre egy 10 elemű egydimenziós tömböt, és töltsd fel véletlenszerű egész számokkal 1-100-ig! 
            2. A tömb elemei írasd ki **foreach** segítségével!
            3. Keresd meg a legnagyobb és legkisebb elemet a tömbben!
            4. Rendezd a tömböt növekvő sorrendbe, majd írd ki az eredményt!*/

            int[] szamok = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,101);
            }

            foreach (var szam in szamok)
            {
                Console.Write($"{szam} ");
            }

            


            Console.WriteLine();

            Console.WriteLine(String.Join(" | ",szamok));

            //maximum keresés
            Console.WriteLine($"A legnagyobb elem: {szamok.Max()}");


            Console.ReadKey();
        }
    }
}
