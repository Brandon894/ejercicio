using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._12Multiplosde10SumaryContar
{
    class Program
    {
        static float numero;
        static string entrada;
        static int n, sumar, contar;
        static void Main(string[] args)
        {
            n = 10;  
            sumar = 0;  
            contar = 0; 
            numero = 0;  
            entrada = "";  

            sumarycontarlosmultiplosde10();
            
        }

        static public void sumarycontarlosmultiplosde10()
        {
            Console.WriteLine("Ingrese un número: ");  
            entrada = Console.ReadLine(); 
            numero = Convert.ToSingle(entrada);  

            while (n <= numero)  
            {
                Console.WriteLine(n);  
                sumar = sumar + n;  
                n = n + 10;  
                contar = contar + 1;  
            }

            Console.WriteLine("El total de que hay de los multiplos de 10 es de:"+contar); 
            Console.WriteLine("La sumatoria total de los " + contar + " múltiplos de 10 es de: " + sumar);
            Console.ReadKey();
        }
    }
}
