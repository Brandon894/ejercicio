using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._40numeromenorprimo
{
    class Program
    {
        static string entrada;
        static int dato, contar;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para saber si es primo y para saber cual es su menor número primo");
            entrada = Console.ReadLine();
            dato = Convert.ToInt32(entrada);

            for (int i = 1; i <= dato; i++)
            {
                if (dato % i == 0)  
                {
                   
                    contar = contar + 1;
                }
            }           
            if (contar == 2)  
            {
                Console.WriteLine(dato + " es un número primo y su menor número primo es 2");  
            }
            else
            {
                Console.WriteLine(dato + " no es un número primo y su menor número primo es 2");  
            }
            Console.ReadKey();
        }
    }
}
