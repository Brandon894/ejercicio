using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._38progresionaritmetica2termi
{
    class Program
    {
        static string entrada;
        static float inicio, final, resta;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número con que se va a iniciar: ");
            entrada = Console.ReadLine();
            inicio = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese el número con que se va a finalizar: ");
            entrada = Console.ReadLine();
            final = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese la diferencia: ");
            entrada = Console.ReadLine();
            resta = Convert.ToSingle(entrada);

            while ((inicio < 0) || (final < 0))
            {
                Console.WriteLine("Ingrese nuevamente el número con que se va a iniciar, Positivo ");
                entrada = Console.ReadLine();
                inicio = Convert.ToSingle(entrada);

                Console.WriteLine("Ingrese nuevamente el número con que se va a finalizar, positivo: ");
                entrada = Console.ReadLine();
                final = Convert.ToSingle(entrada);
            }
         
            while (resta < 0)
            {
                Console.WriteLine("Ingrese la diferencia: ");
                entrada = Console.ReadLine();
                resta = Convert.ToSingle(entrada);
            }
            while (inicio <= final) 
            {
                Console.WriteLine(inicio);  

                inicio = inicio + resta;  
            }
            Console.ReadKey();
        }
    }
}
