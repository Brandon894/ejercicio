using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._28sumarmultiplosde5ymayor
{
    class Program
    {
        static string entrada;
        static int n, contar;
        static float sumar, dato, mayor, numdeterminado;
        static void Main(string[] args)
        {
            n = 1;
            entrada = "";
            mayor = 0;
            dato = 0;
            numdeterminado = 0;
            sumar = 0;
            contar = 0;
            conversion();
        }
        static public void conversion()
        {
            Console.WriteLine("Ingrese un numero");  
            entrada = Console.ReadLine(); 
            numdeterminado = Convert.ToSingle(entrada);  

            while (n <= numdeterminado)  
            {
                Console.WriteLine("Ingrese un número: ");  
                entrada = Console.ReadLine();  
                dato = Convert.ToSingle(entrada);  

                if (dato % 5 == 0)  
                {
                    sumar= sumar + dato; 
                }
                if (dato > mayor)  
                {
                    mayor = dato;  
                }
                n = n + 1;  
                contar = contar + 1;  

            }

          
            Console.WriteLine("La suma de los múltiplos de 5 es de: " + sumar);
            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("Usted ingresó un total de: " + contar + " números");
            Console.ReadKey();
        }
    }
}
