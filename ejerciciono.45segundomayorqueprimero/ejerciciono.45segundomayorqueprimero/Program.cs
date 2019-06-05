using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._45segundomayorqueprimero
{
    class Program
    {
        static string entrada;
        static float dato1, dato2, sumarimpar;
        static int n, contar, contarpar;
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ingrese un número: ");
                entrada = Console.ReadLine();
                dato1 = Convert.ToSingle(entrada);
                n = Convert.ToInt32(dato1);

                Console.WriteLine("Ingrese un número mayor que: " + dato1);
                entrada = Console.ReadLine();
                dato2 = Convert.ToSingle(entrada);

                while (dato2 < dato1)
                {
                    Console.WriteLine("El número ingresado es menor que: " + dato1 + " ingrese nuevamente un número mayor que " + dato1);
                    entrada = Console.ReadLine();
                    dato2 = Convert.ToSingle(entrada);
                }
            }
            {
                while (n <= dato2)
                {
                    Console.WriteLine(n);

                    if (n % 2 == 0)
                    {
                        contarpar = contarpar + 1;
                    }
                    else
                    {
                        sumarimpar = sumarimpar + n;
                    }
                    contar = contar + 1;
                    n = n + 7;
                }
                Console.WriteLine("Hay un total de: " + contarpar + " números pares");
                Console.WriteLine("La suma de los números impares es de: " + sumarimpar);
                Console.WriteLine("Hay un total de: " + contar + " números");
            }
            Console.ReadKey();
        }
    }
}
