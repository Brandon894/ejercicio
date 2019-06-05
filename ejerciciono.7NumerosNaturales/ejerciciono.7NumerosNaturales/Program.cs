using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._7NumerosNaturales
{
    class Program
    {
        static float numero;
          static string  entrada;
        static int n;
        static void Main(string[] args)
        {
            n = 1;
            entrada = "" ;
            numero = 0;

            numerosnaturalesdesde1();
        }
        static private void numerosnaturalesdesde1()
        {
            Console.WriteLine("Ingresa un numero");
            entrada = Console.ReadLine();
            numero = Convert.ToSingle(entrada);
            while (n <=numero)
            {
                Console.WriteLine(n);
                n = n + 1;
                Console.ReadKey();
            }
        }


        }
    }

