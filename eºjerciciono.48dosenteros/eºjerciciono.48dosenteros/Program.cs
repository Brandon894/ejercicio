using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eºjerciciono._48dosenteros
{
    class Program
    {
        static string entrada;
        static int dato1, dato2, sumar, producto, diferencia, cociente, resto;
            static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            dato1 = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el segundo número para hacer operaciones enteras: ");
            entrada = Console.ReadLine();
            dato2 = Convert.ToInt32(entrada);

            //suma
            sumar = dato1 + dato2;
            Console.WriteLine("La suma es de: " + sumar);

            // producto
            producto = dato1 * dato2;
            Console.WriteLine("El producto es de: " + producto);

            // diferencia
            diferencia = dato1 - dato2;
            Console.WriteLine("La diferencia es de: " + diferencia);

            // cociente
            cociente = dato1 / dato2;
            Console.WriteLine("El cociente es de: " + cociente);

            // resto
            resto = dato1 % dato2;
            Console.WriteLine("El resto es de: " + resto);

            Console.ReadKey();
        }
    }
}
