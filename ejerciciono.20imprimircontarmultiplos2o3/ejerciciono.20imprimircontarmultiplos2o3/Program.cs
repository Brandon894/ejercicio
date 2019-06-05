using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._20imprimircontarmultiplos2o3
{
    class Program
    {
        static int n, contar;
        static void Main(string[] args)
        {
            n = 1;  
            contar = 0;  

          imprimirycontarmultiploDe2o3();
        }
        static public void imprimirycontarmultiploDe2o3()
        {
            while (n <= 100)  
            {
                if ((n % 2 == 0) || (n % 3 == 0)) 
                {
                    Console.WriteLine(n); 
                    contar = contar + 1;  
                }

                n = n + 1;  
            }

            Console.WriteLine("Hay un total de múltiplos de: " + contar);
            Console.ReadKey();
        }
    }
}
