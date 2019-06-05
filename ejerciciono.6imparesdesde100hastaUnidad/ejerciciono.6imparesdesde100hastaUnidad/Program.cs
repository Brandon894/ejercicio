using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._6imparesdesde100hastaUnidad
{
    class Program
    {
        static int n, sumar;
        static void Main(string[] args)
        {
            n = 99;
            sumar = 0;
            imparesde100a1ysumar();
        }
static private void imparesde100a1ysumar()
        {
            while (n>=1)
            {
                Console.WriteLine(n);
                sumar = sumar + 1;
                n = n - 2 ;
            }
            Console.WriteLine("la suma de los numeros impares de 100 hasta la unidad es de"+ sumar);
            Console.ReadKey();
        }

        }
    }

