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

    }
}
