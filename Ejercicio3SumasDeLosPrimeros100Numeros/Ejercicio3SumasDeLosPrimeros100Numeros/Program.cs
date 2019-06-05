using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3SumasDeLosPrimeros100Numeros
{
    class Program
    {
        static int n, suma;

        static void Main(string[] args)
        {
            n = 1;
            suma = 0;

            sumasDeNumeros();
            Console.ReadKey();
        }
        static private void sumasDeNumeros()
        {
            while (n <= 100)
            {
                suma = suma + n;
                n = n + 1;
                Console.WriteLine(n);
            }

        }
    }
}
