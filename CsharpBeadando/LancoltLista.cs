using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpBeadando
{
    class LancoltLista
    {
        public LancoltLista()
        {
            var lista = new LinkedList<string>();

            //hozzá adás jobbról
            lista.AddLast("három");
            lista.AddLast("négy");

            //hozzá adás balról
            lista.AddFirst("kettő");
            lista.AddFirst("egy");

            Console.WriteLine($"Láncolt lista elemeinek száma: {lista.Count}");
            Console.WriteLine("Láncolt lista tartalma előre:");
            foreach (var elem in lista)
            {
                Console.Write($"{elem} "); //autómatikusan az érték íródik ki
            }
            Console.WriteLine(); //üres sor beszúrása

            Console.WriteLine("A láncolt lista tartalma visszafelé:");
            var utolso = lista.Last;
            while(utolso != null)
            {
                Console.Write($"{utolso.Value} "); //kiíratom az utolsó elemet
                utolso = utolso.Previous;   //veszem az előtte lévő elemet
            }
            Console.WriteLine(); //üres sor beszúrása

            lista.AddLast("kettő");
            Console.WriteLine("Láncolt lista tartalma előre:");
            foreach (var elem in lista)
            {
                Console.Write($"{elem} "); //autómatikusan az érték íródik ki
            }
            Console.WriteLine(); //üres sor beszúrása


            LinkedListNode<string> node = lista.Find("kettő");
            lista.AddAfter(node, "proba");

            Console.WriteLine("Láncolt lista tartalma előre:");
            foreach (var elem in lista)
            {
                Console.Write($"{elem} "); //autómatikusan az érték íródik ki
            }
            Console.WriteLine(); //üres sor beszúrása


            lista.Remove("kettő");
            Console.WriteLine("Láncolt lista tartalma előre:");
            foreach (var elem in lista)
            {
                Console.Write($"{elem} "); //autómatikusan az érték íródik ki
            }
            Console.WriteLine(); //üres sor beszúrása


            lista.RemoveFirst();        //első elem törlése
            lista.RemoveLast();         //utolsó elem törlése
            foreach (var elem in lista)
            {
                Console.Write($"{elem} "); //autómatikusan az érték íródik ki
            }
            Console.WriteLine(); //üres sor beszúrása

            node = lista.Find("proba");
            lista.AddBefore(node, "kék");
            lista.AddBefore(node, "piros");
            lista.AddAfter(node, "sárga");
            lista.AddAfter(node, "zöld");
            foreach (var elem in lista)
            {
                Console.Write($"{elem} "); //autómatikusan az érték íródik ki
            }
            Console.WriteLine(); //üres sor beszúrása

            lista.Remove(node);
            foreach (var elem in lista)
            {
                Console.Write($"{elem} "); //autómatikusan az érték íródik ki
            }
            Console.WriteLine(); //üres sor beszúrása

        }







    }
}
