using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._37cifras
{
    class Program
    {
        static int Entero, contador;
        static string entrada;
        static double numTruncado;
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ingrese un número entero positivo: ");
                entrada = Console.ReadLine();
                Entero = Convert.ToInt32(entrada);

                while (Entero < 0)
                {
                    Console.WriteLine("El numero " +Entero+ " es negativo ingrese un numero entero positivo ");
                    entrada = Console.ReadLine();
                    Entero = Convert.ToInt32(entrada);
                }
            }
            {
                numTruncado = Convert.ToSingle(Entero);

                while (numTruncado != 0)
                {
                    numTruncado = (Math.Truncate(numTruncado) / 10);
                    contador = contador + 1;
                }

                Console.WriteLine("El número ingresado tiene " + contador + " cifras");
            }
            Console.ReadKey();
        }
    }
}
