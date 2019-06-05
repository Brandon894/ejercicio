using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._49tresnumenteros
{
    class Program
    {
        static string entrada;
        static int dato1, dato2, dato3;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número ");
            entrada = Console.ReadLine();
            dato1 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número ");
            entrada = Console.ReadLine();
            dato2 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el tercer número  ");
            entrada = Console.ReadLine();
            dato3 = Convert.ToInt32(entrada);

            Console.WriteLine("La suma de los números es de: " + (dato1 + dato2 + dato3));

            Console.WriteLine("La media aritmética de los números es de: " + ((dato1 + dato2 + dato3) / 3));

            //Proceso para comparar los tres números
            if ((dato1 > dato2) && (dato1 > dato3))
            {
                Console.WriteLine("El número mayor es " + dato1);
            }
            else
            {
                if (dato2 > dato3)
                {
                    Console.WriteLine("El número mayor es " + dato2);
                }
                else
                {
                    Console.WriteLine("El número mayor es " + dato3);

                }
            }

            //Proceso para ver que número es el menor de los tres.
            if ((dato1 < dato2) && (dato1 < dato3))
            {
                Console.WriteLine("El número menor es " + dato1);
            }
            else
            {
                if (dato2 < dato3)
                {
                    Console.WriteLine("El número menor es " + dato2);
                }
                else
                {
                    Console.WriteLine("El número menor es " + dato3);
                }
                }
            Console.ReadKey();
        }
    }
}
