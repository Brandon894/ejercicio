using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._16
{
    class Program
    {
        static string entrada;
        static float numero;       
        static void Main(string[] args)
        {
            numero = 0;  
            entrada = "";  

            PositivoNegativo();
        }

        static public void PositivoNegativo()
        {
            Console.WriteLine("Ingrese un número para saber si es positivo o negativo: ");  
            entrada = Console.ReadLine();  
            numero = Convert.ToSingle(entrada);  

            if (numero > 0)  
            {
                Console.WriteLine("El número ingresado es positivo: ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El número ingresado es negativo: ");
                Console.ReadKey();
            }
        }
    }
}
