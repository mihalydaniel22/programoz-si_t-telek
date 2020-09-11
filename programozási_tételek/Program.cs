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
            Console.ReadKey();
        }

        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            }
        }
    }
}
