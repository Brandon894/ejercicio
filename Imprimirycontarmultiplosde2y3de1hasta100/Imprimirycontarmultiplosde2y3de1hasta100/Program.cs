using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimirycontarmultiplosde2y3de1hasta100
{
    class Program
    {
        static int n, contar; 
        static void Main(string[] args)
        {
            n = 0;
            contar = 0;

            Imprimirycontarmultiplosde2y3de1hasta100();
        }
        static public void Imprimirycontarmultiplosde2y3de1hasta100()
        {          
                while (n <= 100)  
                {
                    if (( n% 2 == 0) && (n % 3 == 0)) 
                    {
                 Console.WriteLine(n);  
                 contar = contar + 1;  
         }
                    n = n + 1; 
         }

                Console.WriteLine("Hay un total de " + contar + " múltiplos de 2 y de 3 desde uno hasta cien");
            Console.ReadKey();
            }
    }
}
