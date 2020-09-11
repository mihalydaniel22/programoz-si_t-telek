using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programozási_tételek
{
    class Program
    {
        static int[] tomb = new int[]{12, 7, 2, 4, 45, 99, 1, 8, 95, 50};

        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            oszt3mal();
            eldontes();
            kivalasztas();
            kereses();
            Console.ReadKey();
        }

        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            }
        }
        static void Osszegzes()
        {
            int eredmeny = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                eredmeny = eredmeny + tomb[i];
            }
            Console.WriteLine("\nÖsszeg: {0}", eredmeny);
        }
        static void oszt3mal()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3==0)
                {
                    db++;
                }
            }
            Console.WriteLine("3-mal osztható számok száma: {0}", db);
        }
        static void eldontes()
        {
            int eldont = 0;
            while (eldont < tomb.Length && tomb[eldont] != 69)
            {
                eldont++;
            }
            if (eldont < tomb.Length)
            {
                Console.WriteLine("A tömmben van 69");
            }
            else
            {
                Console.WriteLine("A tömben nincs 69");
            }
        }
        static void kivalasztas()
        {
            int kiv = 0;
            while (tomb[kiv] != 50)
            {
                kiv++;
            }
            Console.WriteLine("{0}-dik elem az 50", kiv);
        }
        static void kereses()
        {
            int keres = 0;
            while (keres < tomb.Length && tomb[keres] != 50)
            {
                keres++;
            }
            if (keres < tomb.Length)
            {
                Console.WriteLine("A tömmben van 50, a {0}-dik helyen", keres+1);
            }
            else
            {
                Console.WriteLine("A tömben nincs ilyen");
            }
        }

    }
}
