using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_no._4
{
    class Paresdel0al100
    {
        static int n;
        static void Main(string[] args)
        {
            n = 0;

            numerosPares0al100();
            Console.ReadKey();
        }

        static private void numerosPares0al100()
        {
            while (n <= 100)
            {
                Console.WriteLine(n); 
                n = n + 2;
            }
        }
    }
}
