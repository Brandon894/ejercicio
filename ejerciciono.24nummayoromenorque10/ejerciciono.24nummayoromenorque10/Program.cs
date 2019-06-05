using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._24nummayoromenorque10
{
    class Program
    {
        static int n;
        static float num;
        static string entrada;
        static void Main(string[] args)
        {
           // n = 1;
            numeromayoromenorque10();
        }
        static public void numeromayoromenorque10()
        {

            for (n = 1; n<=5 ; n = n + 1)
            {
                Console.WriteLine("Ingrese un número "); 
                entrada = Console.ReadLine();
                num = Convert.ToSingle(entrada);
                if (num> 10)  
                {
                    Console.WriteLine(num + " es mayor que 10");  
                }
                else
                {
                    Console.WriteLine(num + " es menor que 10");  
                }
                Console.ReadKey();
            }
        }
    }
}
