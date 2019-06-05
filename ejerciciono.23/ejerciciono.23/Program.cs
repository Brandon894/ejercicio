using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._23
{
    class Program
    {
        static string entrada;
        static int primero, segundo, contar, contarpar, contarimpar;
        static void Main(string[] args)
        {
            ingresardatos();
            sumatoriadecontarparcontarimparycontar();
        }
        static public void ingresardatos()
        {
            Console.WriteLine("Ingrese el primer número: ");  
            entrada = Console.ReadLine();  
            primero = Convert.ToInt32(entrada); 

            Console.WriteLine("Ingrese el segundo número: "); 
            entrada = Console.ReadLine();  
            segundo = Convert.ToInt32(entrada);
        }
        static public void sumatoriadecontarparcontarimparycontar()
        {
            if (primero < segundo)  
            {
                while (primero <= segundo)  
                {
                    Console.WriteLine(primero);  
                    if (primero % 2 == 0)  
                    {
                        contarpar = contarpar + 1;  
                    }
                    else
                    {
                        contarimpar = contarimpar + primero;  
                    }

                    contar = contar + 1;  
                    primero = primero + 1;   
                }
            }
            else
            {
                while (segundo <= primero)  
                {
                    Console.WriteLine(segundo);  
                    if (segundo % 2 == 0)  
                    {
                        contarpar = contarpar + 1;  
                    }
                    else
                    {
                        contarimpar = contarimpar + primero;
                    }

                    contar = contar + 1;  
                    segundo = segundo + 1; 
                }

            }

            Console.WriteLine("Existe un total de: " + contar + " números naturales");  
            Console.WriteLine("Existe un total de: " + contarpar + " números pares"); 
            Console.WriteLine("La suma de los números impares es de: " + contarimpar);
            Console.ReadKey();
        }
    }
}
