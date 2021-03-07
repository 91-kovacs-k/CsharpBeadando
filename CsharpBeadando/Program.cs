using System;
using System.Collections;

namespace CsharpBeadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Teendok<int> teendok = new Teendok<int>();
            teendok.ElejehezAd(5);
            teendok.ElejehezAd(1, 2, 3);
            teendok.VegehezAd(8);
            teendok.Torol(2);
            teendok.ElejehezAd(4);
            Kiir(teendok);




        }

        public static void Kiir(IEnumerable lista)
        {
            //lista elemeinek kiíratása
            foreach (object elem in lista)
            {
                Console.WriteLine($"{elem}");
            }
            //üres sor beszúrása a lista után
            Console.WriteLine();
        }
    }
}
