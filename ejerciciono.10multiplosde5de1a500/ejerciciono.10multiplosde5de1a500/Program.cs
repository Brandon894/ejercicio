using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._10multiplosde5de1a500
{
    class Program
    {
        static int n, suma;
        static void Main(string[] args)
        {
            n = 5;
            suma = 0;

            multiplosde5de1a500();
        }
        static public void multiplosde5de1a500()
        {
while (n <=500)
            {
                Console.WriteLine(n);
                suma = suma + 1;
                n = n + 5;
            }
            Console.WriteLine("El total de los multiplos de 5 de 1 a 500 es de " + suma);
            Console.ReadKey();
        }
    }
}
