using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._8_multiplosde3
{
    class Program
    {
        static int n, contar;
        static void Main(string[] args)
        {
            n = 3;
            contar = 0;

            multiplosde3al100();
        }
        static private void multiplosde3al100()
        {
            while (n <= 100)
            {
                Console.WriteLine(n);
                n = n + 3;
                contar = contar + 1;
            }
            Console.WriteLine("El total de los multiplos de 3 es de "+contar);
            Console.ReadKey();
        }
    }
}
