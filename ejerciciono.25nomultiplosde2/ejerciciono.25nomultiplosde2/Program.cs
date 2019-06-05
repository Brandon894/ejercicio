using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._25nomultiplosde2
{
    class Program
    {
        static int n, dato;
        static string entrada;
        static void Main(string[] args)
        {
            n = 0;
            dato = 0;
            entrada = "";

            numerosde1a100();
        }
        static public void numerosde1a100()
        {
            Console.WriteLine("Ingrese un número: ");
            entrada = Console.ReadLine();
            dato = Convert.ToInt32(entrada);

            n = dato;
            if (n % 2 == 1)
            {
                while (n <= 100)
                {
                    if (n % 2 == 1)
                    {
                        Console.WriteLine(n);
                        n = n + 1;
                    }
                    else
                    {
                        n = n + 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error!!! Usted ingresó un múltiplo de 2");
            }
            Console.ReadKey();
        }
    }
}
