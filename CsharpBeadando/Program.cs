using System;
using System.Collections;

namespace CsharpBeadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Teendok<string> teendok = new Teendok<string>();
            //listához adok néhány tennivalót
            teendok.VegehezAd("bevásárlás", "pénz felvétel", "főzés");
            Kiir(teendok);
            //a végéhez illetve az elejére írok néhány új tennivalót
            teendok.VegehezAd("takarítás", "tanulás", "festés");
            teendok.ElejehezAd("tankolás", "gyerekért menni az oviba", "filmezés a családdal");
            Kiir(teendok);
            //a már listán szereplő tevékenységek nem kerülnek fel újra
            teendok.VegehezAd("festés");
            teendok.ElejehezAd("festés");
            Kiir(teendok);
            //a pénzt célszerű azelőtt felvenni, mielőtt bevásárolnánk
            var sikeres = teendok.Cserel("bevásárlás", "pénz felvétel");
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Console.WriteLine();
            Kiir(teendok);
            //ha olyat cserélnék ami nincs a listában, nem történik meg a csere
            sikeres = teendok.Cserel("festés", "pihenés");
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Console.WriteLine();
            Kiir(teendok);
            //lista törlése
            teendok.ListaTorol();

            //a teendok osztály generikus, lehet más típussal is létrehozni
            Console.WriteLine("***SZÁMOK***");
            Teendok<int> szamok = new Teendok<int>();
            //listához adok néhány számot
            szamok.VegehezAd(4, 35, 12);
            Kiir(szamok);
            //a végéhez illetve az elejére írok néhány új számot
            szamok.VegehezAd(32, 2, 15);
            szamok.ElejehezAd(18, 1, -32);
            Kiir(szamok);
            //a már listán szereplő számok nem kerülnek fel újra
            szamok.VegehezAd(4);
            szamok.ElejehezAd(4);
            Kiir(szamok);
            //a számokat lehet cserélni a listán
            sikeres = szamok.Cserel(18, 1);
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Console.WriteLine();
            Kiir(szamok);
            //ha olyat cserélnék ami nincs a listában, nem történik meg a csere
            sikeres = szamok.Cserel(1, -1);
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Console.WriteLine();
            Kiir(szamok);
            //lista törlése
            szamok.ListaTorol();





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
