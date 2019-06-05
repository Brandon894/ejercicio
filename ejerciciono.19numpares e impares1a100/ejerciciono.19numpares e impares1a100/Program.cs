using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._19numpares_e_impares1a100
{
    class Program
    {
        static int n, totalPar, totalimpar;
        static void Main(string[] args)
        {

            n = 1;  
            totalPar = 0;  
            totalimpar = 0;  

            numerospareseimparesdel1al100();
        }
        static public void numerospareseimparesdel1al100()
        {
         
        
            while (n <= 100)  
            {
                Console.WriteLine(n);  

                if (n % 2 == 0)  
                {
                    totalPar = totalPar + n;  
                }
                else
                {
                    totalimpar = totalimpar + n;  

                }
                n = n + 1;  
            }

            Console.WriteLine("La suma de los números pares de 1 a 100 es de: " + totalPar);  
            Console.WriteLine("La suma de los números impares de 1 a 100 es de: " + totalimpar);
            Console.ReadKey();
        
    }
    }
}
