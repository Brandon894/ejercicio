using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._26multiplosde5ymas
{
    class Program
    {
        static int n, sumar, multiplo;
        static string entrada;
        static float dato;
        static void Main(string[] args)
        {
            multiplosde5ymas();

        }
        static public void multiplosde5ymas ()
        {
            Console.WriteLine("Ingrese un número:");  
            entrada = Console.ReadLine();  
            dato = Convert.ToSingle(entrada); 

            while (n <= dato)  
            {
                if (n % 5 == 0)  
                {
                    multiplo = multiplo + n;  
                    n = n + 1; 
                }
                else
                {
                    Console.WriteLine(n); 
                    sumar = sumar + n;  
                    n = n + 1; 
                }
            }

            Console.WriteLine("La suma total de los numeros, excepto los múltiplos de 5 desde cero a " + dato + " es de: " + sumar);  
            Console.WriteLine("La suma de los múltiplos de 5 desde cero a " + dato + " es de: " + multiplo);
            Console.ReadKey();
        }
    }
}
