using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._46contarysumarmultiplosde2
{
    class Program
    {
        static string entrada;
        static int dato1, dato2, n, sumar, contar;
        static void Main(string[] args)
        {
            //IngresoDeNumerosYBucleNegativos
            Console.WriteLine("Ingrese el primer número entero positivo: ");  
                entrada = Console.ReadLine(); 
                dato1 = Convert.ToInt32(entrada);  
                n = dato1;  

                Console.WriteLine("Ingrese un número entero positivo mayor que: " + dato1);  
                entrada = Console.ReadLine();  
                dato2 = Convert.ToInt32(entrada);


            while ((dato1 < 0) || (dato2 < 0))
            {
                Console.WriteLine("Usted ingresó números negativos");
                Console.WriteLine("Ingrese el primer número entero positvo: ");
                entrada = Console.ReadLine();
                dato1 = Convert.ToInt32(entrada);
                n = dato1;

                Console.WriteLine("Ingrese un número entero positivo mayor que: " + dato1);
                entrada = Console.ReadLine();
                dato2 = Convert.ToInt32(entrada);
            }
            // NumeroMayoroMenor
            while (dato2 < dato1)
            {
                Console.WriteLine("El número ingresado es menor que: " + dato1 + " ingrese nuevamente un número mayor que " + dato1);   
                entrada = Console.ReadLine(); 
                dato2 = Convert.ToInt32(entrada);  
            }
            // BucleParaImpresionDeMultiplos2
            while (n <= dato2)  
            {
                if (n % 2 == 0) 
                {
                    Console.WriteLine(n);  
                    sumar = sumar + n;  
                    contar = contar + 1;  
                    n = n + 2; 
                }
                else
                {
                    dato1 = dato1 + 1; 
                    n = dato1;  
                    Console.WriteLine(n);  
                    sumar= sumar + n; 
                    contar = contar + 1; 
                    n = n + 2; 
                }
            }
            Console.WriteLine("Hay un total de: " + contar + " múltiplos de 2");
            Console.WriteLine("La suma total de los múltiplos de 2 es de: " + sumar);
            Console.ReadKey();
        }      
    }
}
