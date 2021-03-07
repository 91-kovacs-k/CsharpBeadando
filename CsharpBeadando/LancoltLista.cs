using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpBeadando
{
    class LancoltLista<T> : IEnumerable
    {
        //a teendők tárolása LinkedList-ben
        private LinkedList<T> lista;

        //konstruktor inicializál
        public LancoltLista()
        {
            lista = new LinkedList<T>();
        }

        //GetEnumerator
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)lista).GetEnumerator();
        }

        //listában van-e az adott elem?
        public bool BenneVan(T adat)
        {
            if (lista.Contains(adat))
            {
                return true;
            }
            return false;
        }

        //teendő listához (végéhez) adása
        public void VegehezAd(params T[] adatok)
        {
            foreach (var adat in adatok)
            {
                //csak akkor adjuk hozzá, ha még nem volt benne a listában
                if (BenneVan(adat))
                {
                    continue;
                }
                lista.AddLast(adat);
            }
        }

        //teendő listához (elejéhez) adása
        public void ElejehezAd(params T[] adatok)
        {
            //ha egy paramétert kapott, akkor beszúrja az lista elejére
            if (adatok.Length == 1)
            {
                //csak akkor adjuk hozzá, ha még nem volt benne a listában
                if (BenneVan(adatok[0]))
                {
                    return;
                }
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
                        //csak akkor adjuk hozzá, ha még nem volt benne a listában
                        if (BenneVan(adat))
                        {
                            continue;
                        }
                        lista.AddBefore(Elso, adat);
                    }
                }
            }
        }

        //teendő törlése a listából
        public void ElemTorol(params T[] adatok)
        {
            foreach (var adat in adatok)
            {
                //ha benne van, törlöm a listából
                if (BenneVan(adat))
                {
                    lista.Remove(adat);
                }
                //ha nincs benne a listában, continue
                else
                {
                    continue;
                }
            }
        }

        //a lista törlése
        public void ListaTorol()
        {
            lista.Clear();
        }

        public bool Cserel(T mit, T mire)
        {
            var elso = lista.Find(mit);
            var masodik = lista.Find(mire);

            if (elso != null && masodik != null)
            {
                var tmp1 = elso.Value;
                lista.AddBefore(masodik, tmp1);
                var tmp2 = masodik.Value;
                lista.AddBefore(elso, tmp2);
                lista.Remove(elso);
                lista.Remove(masodik);
                return true;
            }
            return false;
        }
    }
}
