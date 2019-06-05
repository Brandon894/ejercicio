using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._39seriefibbonacci
{
    class Program
    {
        static string entrada;
        static int pos, pre, val;
        static float dato;
        static void Main(string[] args)
        {
            pos = 1;
            Console.WriteLine("Ingrese la cantidad de términos que quiere generar: ");
            entrada = Console.ReadLine();
            dato = Convert.ToSingle(entrada);
         
            Console.WriteLine(pre + "  " + pos);

            for (int n = 3; n <= dato; n++) 
            {
                val = pre + pos;
                pre = pos;
                pos = val;

                Console.WriteLine(val);
            }
            Console.ReadKey();
        }
    }
}
