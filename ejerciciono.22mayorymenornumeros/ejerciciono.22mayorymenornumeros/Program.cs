using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._22mayorymenornumeros
{
    class Program
    {
        static string entrada;
        static float dato, numeroMayor, numeroMenor;
        static int n;
        static void Main(string[] args)
        {
            n = 1;  
            dato = 0;  
            numeroMayor = 0;  
            numeroMenor = 9999;  
            entrada = "";  

            numeroMayorMenorEnSerieDeNumero();
        }
        static public void numeroMayorMenorEnSerieDeNumero()
        {
            while (n <= 5) 
            {
                Console.WriteLine("Ingrese un número: ");  
                entrada = Console.ReadLine();  
                dato = Convert.ToSingle(entrada);  

                if (dato > numeroMayor)  
                {
                    numeroMayor = dato;  
                }

                if (dato < numeroMenor)  
                {
                    numeroMenor = dato;  
                }

                n = n + 1;  
            }

            Console.WriteLine("El número mayor es: " + numeroMayor);  
            Console.WriteLine("El número menor es: " + numeroMenor);
            Console.ReadKey();
        }
    }
}
