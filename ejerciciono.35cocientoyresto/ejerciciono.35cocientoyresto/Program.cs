using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._35cocientoyresto
{
    class Program
    {
        static string entrada;
        static int cociente, resto;
        static float dividendo, divisor;    
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");  
            entrada = Console.ReadLine();  
            dividendo = Convert.ToSingle(entrada);  

            Console.WriteLine("Ingrese el segundo número: ");  
            entrada = Console.ReadLine();  
            divisor = Convert.ToSingle(entrada); 

            
            if ((dividendo >= 0) && (divisor >= 0))  
            {
                resto = Convert.ToInt32(dividendo);
                while (resto >= divisor)  
                {
                    resto = resto - Convert.ToInt32(divisor); 
                    cociente = cociente + 1; 

                }

                Console.WriteLine("El cociente es de: " + cociente); 
                Console.WriteLine("El resto es de: " + resto);  
            }
            else
            {
                Console.WriteLine("Ha ingresado un numero negativo no puede continuar");
            }
            Console.ReadKey();
        }
    }
}
