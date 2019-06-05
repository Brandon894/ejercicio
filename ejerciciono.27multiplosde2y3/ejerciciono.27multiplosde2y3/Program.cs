using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._27multiplosde2y3
{
    class Program
    {
        static string entrada;
        static int n, contar;
        static float dato;
        static void Main(string[] args)
        {
            n = 1;
            contarmultiplosde2y3();

        }
        static public void contarmultiplosde2y3 ()
        {
            Console.WriteLine("Ingrese un numero para imprimir los múltiplos de 2 y 3 hasta el número que acaba de ingresar");
            entrada = Console.ReadLine();
            dato = Convert.ToSingle(entrada);

            while (n <= dato)  
            {
                if ((n % 2 == 0) && (n % 3 == 0))  
                {
                    Console.WriteLine(n);  
                    contar = contar + 1;  
                }

                n = n + 1;  
            }

            Console.WriteLine("Hay un total de " + contar + " múltiplos de 2 y 3, desde la unidad hasta " + dato);
            Console.ReadKey();
        }
    }
}
