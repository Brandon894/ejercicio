using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._30mayoryporcentajes
{
    class Program
    {
        static string entrada;
        static float dato, porciento50, porciento7, resta5porciento, suma5porciento, porciento5, sumaporciento7;
        static void Main(string[] args)
        {
            mayoryporcentajes();
        }
        static public void mayoryporcentajes()
        {
            Console.WriteLine("Ingrese una cantidad: ");  
            entrada = Console.ReadLine();  
            dato = Convert.ToSingle(entrada);  

           
            if (dato < 500)  
            {
                porciento50 = dato * 0.5f;  
                suma5porciento = dato + porciento50;  
                Console.WriteLine("La suma del 50 porciento es de: " + suma5porciento); 
            }
            else
            {
                Console.WriteLine(dato + " es mayor que 500");  
            }

          
            if ((dato >= 500) && (dato < 1000))  
            {
                porciento7 = dato * 0.07f;  
                sumaporciento7 = dato + porciento7;  
                Console.WriteLine("La suma del 7 porciento es de: " + sumaporciento7); 
            }
            else
            {
                Console.WriteLine("Pueda que su cantidad no sea mayor o igual que 500, o no sea menor que 1000 ");  
            }

            
            if ((dato > 1000) && (dato <= 5000))  
            {
                porciento5 = dato * 0.05f;  
                resta5porciento = dato - porciento5;  
                Console.WriteLine("La resta del 5 porciento es de: " + resta5porciento);  
            }
            else
            {
                Console.WriteLine("Pueda ser que la cantidad no sea mayor que 1000, o no sea menor o igual que 5000");  
            }
            Console.ReadKey();
        }

    }
}
