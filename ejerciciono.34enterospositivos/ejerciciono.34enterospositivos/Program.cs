using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._34enterospositivos
{
    class Program
    {
        static string entrada;
        static int n, contar;
        static float dato1, dato2;
        static void Main(string[] args)
        {
            contar = 1;
            resta();
        }
        static public void resta()
        {
            Console.WriteLine("Ingrese el primer número: ");
            entrada = Console.ReadLine();
            dato1 = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese el segundo número: ");
            entrada = Console.ReadLine();
            dato2 = Convert.ToSingle(entrada);


            if ((dato1 >= 0) && (dato2 >= 0))
            {
                while (contar <= dato1)
                {
                    contar = contar + 1;
                    n = n + Convert.ToInt32(dato2);
                }

                Console.WriteLine("El producto de los dos números mediante sumas suceivas es de: " + n);
            }
            else
            {
                Console.WriteLine("Ha ingresado un numero negativo no puede seguir");
            }
            Console.ReadKey();
        }
    }
}
