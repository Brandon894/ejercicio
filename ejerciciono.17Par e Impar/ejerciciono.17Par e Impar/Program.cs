using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._17Par_e_Impar
{
    class Program
    {
        static string entrada;
        static float dato;
        static void Main(string[] args)
        {
            entrada = "";
            dato = 0;   

           PositivoNegativo();          
        }
        
        static public void PositivoNegativo()
        {
            Console.WriteLine("Ingrese un dato para saber si es par o impar: "); 
            entrada = Console.ReadLine();  
            dato = Convert.ToSingle(entrada);  

            if (dato % 2 == 0)  
            {
                Console.WriteLine("El dato ingresado es par ");  
            }
            else
            {
                Console.WriteLine("El dato ingresado es impar ");
                Console.ReadKey();
            }
        }
    }
}
