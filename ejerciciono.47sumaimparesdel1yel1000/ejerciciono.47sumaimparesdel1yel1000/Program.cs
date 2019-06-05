using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._47sumaimparesdel1yel1000
{
    class Program
    {
        static int n, sumarimpar;
        static void Main(string[] args)
        {
            n = 1; 
            while (n <= 1000)
            {
                Console.WriteLine(n);                
                if (n % 2 == 1)  
                {
                    sumarimpar = sumarimpar + n;  
                }

                n = n + 1;  
            }
            Console.WriteLine("La suma total de los números impares del 1 al 100 es de: " + sumarimpar);
            Console.ReadKey();
        }
    }
}
