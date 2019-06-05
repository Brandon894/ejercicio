using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._18multiplosde3
{
    class Program
    {
        static float dato;      
        static string entrada;
        static int contar, n;
        static void Main(string[] args)
        {
            n = 3;  
            contar = 0; 
            entrada = "";  
            dato = 0; 

            multiplosdetresDesdeUno();
            Console.ReadKey();
        }

        static public void multiplosdetresDesdeUno()
        {
            Console.WriteLine("Ingrese un número para saber los múlitplos de tres desde la unidad hasta su número ingresado: ");
            entrada = Console.ReadLine();  
            dato= Convert.ToSingle(entrada); 

            while (n <= dato)  
            {
                Console.WriteLine(n); 
                n = n + 3;  
                contar = contar + 1;  
            }

            Console.WriteLine("Hay un  total de " + contar + " múltiplos de 3 de la unidad hasta " + dato);
        }
    }
}
