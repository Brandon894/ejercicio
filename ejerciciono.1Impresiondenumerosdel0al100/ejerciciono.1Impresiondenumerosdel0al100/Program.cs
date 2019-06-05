using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._1Impresiondenumerosdel0al100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 100)
            {
                Console.WriteLine(n);
                n = n + 1;
            }
            Console.ReadKey();

        }
    }
}
