using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._49_tres_numeros_enteros
{
    class Program
    {
        static string entrada;
        static int dato1, dato2, dato3;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            dato1 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            dato2 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el tercer número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            dato3 = Convert.ToInt32(entrada);
            
            Console.WriteLine("La suma de los números es de: " + (dato1 + dato2 + dato3));

            Console.WriteLine("La media aritmética de los números es de: " + ((dato1 + dato2 + dato3) / 3));
        
            //comparacionDeNumeros
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
