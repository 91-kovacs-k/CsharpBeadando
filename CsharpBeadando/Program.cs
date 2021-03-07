using System;
using System.Collections;

namespace CsharpBeadando
{
    class Program
    {
        static void Main(string[] args)
        {
            LancoltLista<string> teendok = new LancoltLista<string>();
            //listához adok néhány tennivalót
            Console.WriteLine("Tennivalók hozzáadása:");
            teendok.VegehezAd("bevásárlás", "pénz felvétel", "főzés", "mosás");
            Kiir(teendok);
            //a végéhez illetve az elejére írok néhány új tennivalót
            Console.WriteLine("Tennivalók hozzáadása elejéhez, végéhez:");
            teendok.VegehezAd("takarítás", "tanulás", "festés");
            teendok.ElejehezAd("tankolás", "gyerekért menni az oviba", "filmezés a családdal");
            Kiir(teendok);
            //a már listán szereplő tevékenységek nem kerülnek fel újra
            Console.WriteLine("A már listán szereplő tevékenységek nem kerülnek rá duplán:");
            teendok.VegehezAd("festés");
            teendok.ElejehezAd("festés");
            Kiir(teendok);
            //a pénzt célszerű azelőtt felvenni, mielőtt bevásárolnánk
            var sikeres = teendok.Cserel("bevásárlás", "pénz felvétel");
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Kiir(teendok);
            //ha olyat cserélnék ami nincs a listában, nem történik meg a csere
            sikeres = teendok.Cserel("festés", "pihenés");
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Kiir(teendok);
            //törölni lehet bármelyik teendőt
            Console.WriteLine("Törlöm a festést, takarítást és főzést a listáról:");
            teendok.ElemTorol("festés", "takarítás", "főzés");
            Kiir(teendok);
            //lista törlése
            teendok.ListaTorol();

            //a teendok osztály generikus, lehet más típussal is létrehozni
            Console.WriteLine("***SZÁMOK***");
            LancoltLista<int> szamok = new LancoltLista<int>();
            //listához adok néhány számot
            Console.WriteLine("Listához adok néhány számot:");
            szamok.VegehezAd(4, 35, 12, 99);
            Kiir(szamok);
            //a végéhez illetve az elejére írok néhány új számot
            Console.WriteLine("Elejéhez illetve a végéhez adok néhány számot:");
            szamok.VegehezAd(32, 2, 15);
            szamok.ElejehezAd(18, 1, -32);
            Kiir(szamok);
            //a már listán szereplő számok nem kerülnek fel újra
            Console.WriteLine("A már listán szereplő számok nem kerülnek fel duplán:");
            szamok.VegehezAd(4);
            szamok.ElejehezAd(4);
            Kiir(szamok);
            //a számokat lehet cserélni a listán
            sikeres = szamok.Cserel(18, 1);
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Kiir(szamok);
            //ha olyat cserélnék ami nincs a listában, nem történik meg a csere
            sikeres = szamok.Cserel(1, -1);
            Console.WriteLine("A csere " + (sikeres ? "befejeződött!" : "nem sikerült!"));
            Kiir(szamok);
            //törölni lehet bármelyik számot
            Console.WriteLine("Törlöm a listáról a 18-at, 32-őt és 15-öt:");
            szamok.ElemTorol(18, 32, 15);
            Kiir(szamok);
            //lista törlése
            szamok.ListaTorol();
        }
        //kiíratás
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
