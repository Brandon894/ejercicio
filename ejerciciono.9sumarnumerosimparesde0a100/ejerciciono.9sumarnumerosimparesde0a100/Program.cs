using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._9sumarnumerosimparesde0a100
{
    class Program
    {
        static int n, sumar;
        static void Main(string[] args)
        {
            sumar = 0;
            n = 1;
            sumaimparesde0a100();
        }
        static private void sumaimparesde0a100()
        {
            while (n <= 100)
            {
                Console.WriteLine(n);
                sumar = sumar + 1;
                n = n + 2;
            }
            Console.WriteLine(" la sumatoria de los numeros impares de los numeros de 0 a 100 es de" + sumar);
            Console.ReadKey();
        }
    }
}
