using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpBeadando
{
    class Teendok<T> : IEnumerable
    {
        //a teendők tárolása LinkedList-ben
        private LinkedList<T> lista;

        //üres konstruktor
        public Teendok()
        {
            lista = new LinkedList<T>();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)lista).GetEnumerator();
        }

        //teendő listához (végéhez) adása
        public void VegehezAd(params T[] adatok)
        {
            foreach (var adat in adatok)
            {
                lista.AddLast(adat);
            }
        }
        //teendő listához (elejéhez) adása
        public void ElejehezAd(params T[] adatok)
        {
            //ha egy paramétert kapott, akkor beszúrja az lista elejére
            if (adatok.Length == 1)
            {
                lista.AddFirst(adatok[0]);
            }
            //ha több paramétert kapott olyan sorrendben szúrja be az adatokat, ahogy kapta
            else
            {
                //ha a lista még üres, az első kapott elemet hozzáadjuk
                if (lista.Count == 0)
                {
                    lista.AddFirst(adatok[0]);
                    LinkedListNode<T> Elso = lista.First;
                    foreach (var adat in adatok)
                    {
                        lista.AddBefore(Elso, adat);
                    }
                    //a duplikált elem törlése, ami jelenleg az utolsó helyen van
                    lista.RemoveLast();
                }
                //ha a lista nem üres, akkor a kapott elemeket beszúrjuk a kapott
                //sorrendben a lista elejére
                else
                {
                    LinkedListNode<T> Elso = lista.First;
                    foreach (var adat in adatok)
                    {
                        lista.AddBefore(Elso, adat);
                    }
                }
            }
        }

        //teendő törlése a listából
        public void Torol(params T[] adatok)
        {
            foreach (var adat in adatok)
            {
                //megkeresem a kapott adatot a listában
                var talalat = lista.Find(adat);

                //ha nincs benne a listában, continue
                if (talalat == null)
                {
                    continue;
                }
                //ha benne van, törlöm a listából
                else
                {
                    lista.Remove(talalat);
                }
            }
        }
    }
}
