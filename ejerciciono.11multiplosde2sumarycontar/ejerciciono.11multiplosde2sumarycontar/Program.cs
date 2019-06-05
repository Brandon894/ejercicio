using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._11multiplosde2sumarycontar
{
    class Program
    {
        static string entrada;
        static float numero;
        static int n, sumar, contar;

        static void Main(string[] args)
        {
            n = 2;
            sumar = 0;
            contar = 0;
            numero = 0;
            entrada = "";

            sumarycontarmultiplosde2();
        }
        static public void sumarycontarmultiplosde2()
        {
            Console.WriteLine("Ingrese un numero");
            entrada = Console.ReadLine();
            numero = Convert.ToSingle(entrada);
            while (n<=numero)
            {
                Console.WriteLine(n);
                n = n + 2;
                sumar = sumar + n;
                contar = contar + 1;
            }
            Console.WriteLine("La suma total de los multiplos de 2 que hay es de:" + sumar);
            Console.WriteLine("El total de de los multiplos de 2 que hay es de: " + contar);
            Console.ReadKey();
        }
        }
    }

