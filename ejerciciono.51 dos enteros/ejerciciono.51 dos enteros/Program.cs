using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._51_dos_enteros
{
    class Program
    {
        static string entrada;
        static int dato1, dato2;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            entrada = Console.ReadLine();
            dato1 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número: ");
            entrada = Console.ReadLine();
            dato2 = Convert.ToInt32(entrada);

            if (dato1 % dato2 == 0)
            {
                Console.WriteLine(dato1 + " es múltiplo de " + dato2);
            }
            else
            {
                Console.WriteLine(dato1 + " no es múltiplo de " + dato2);
            }
            Console.ReadKey();
        }
    }
}
