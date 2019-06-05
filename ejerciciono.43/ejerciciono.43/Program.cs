using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._43
{
    class Program
    {
        static string entrada;
        static int dato1, dato2, contar, contarPar, sumaImpar;
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ingrese el primer número: "); 
                entrada = Console.ReadLine(); 
                dato1 = Convert.ToInt32(entrada); 

                Console.WriteLine("Ingrese el segundo número: ");  
                entrada = Console.ReadLine();  
                dato2 = Convert.ToInt32(entrada); 
            }

            {
                if (dato1 < dato2)  
                {
                    while (dato1 <= dato2)  
                    {
                        Console.WriteLine(dato1);  
                        if (dato1 % 2 == 0)  
                        {
                            contarPar = contarPar + 1;  
                        }
                        else
                        {
                            sumaImpar = sumaImpar + dato1;  
                        }

                        contar = contar + 1;  
                        dato1 = dato1 + 1;  
                    }
                }
                else
                {
                    while (dato2 <= dato1)  
                    {
                        Console.WriteLine(dato2);   
                        if (dato2 % 2 == 0)  
                        {
                            contarPar = contarPar + 1;  
                        }
                        else
                        {
                            sumaImpar = sumaImpar + dato1;  
                        }

                        contar = contar + 1;  
                        dato2 = dato2 + 1;  
                    }

                }

                Console.WriteLine("Hay un total de: " + contar + " números naturales");  
                Console.WriteLine("Hay un total de: " + contarPar + " números pares"); 
                Console.WriteLine("La suma de los números impares es de: " + sumaImpar);  
            }
            Console.ReadKey();
        }
    }
}
