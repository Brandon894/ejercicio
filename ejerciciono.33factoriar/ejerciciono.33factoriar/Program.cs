using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._33factoriar
{
    class Program
    {
        static int n;
        static float factor, dato;
        static string entrada;
        static void Main(string[] args)
        {
            n = 1;
            factor = 1;
            factorizacion();
        }
        static public void factorizacion()
        {
            Console.WriteLine("Ingrese un número para saber su factorial: ");
            entrada = Console.ReadLine();
            dato = Convert.ToSingle(entrada);


            while (n <= dato)
            {
                factor = factor * n;
                n = n + 1;
            }
            if (dato >= 0)
            {
                Console.WriteLine("La factorial del número es de: " + factor);
            }
            else
            {
                Console.WriteLine("Los números negativos no tienne factorial");
            }
            Console.ReadKey();
        }
    }
}
