using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._14lasumadecuadrados
{
    class Program
    {
        static int n, sumar, potencia;
        static double numeros;
        static void Main(string[] args)
        {
            n = 0;
            numerosparesdel0al100Cuadrados();
        }
        static public void numerosparesdel0al100Cuadrados()
        {
            while (n <= 100) 
            {
                Console.WriteLine(n);
                numeros = Math.Pow(n, 2);
                potencia = Convert.ToInt32(numeros);
                sumar = sumar + potencia;  
                n = n + 2;
            }
            Console.WriteLine("La sumatoria de los cuadrados de los números pares que hay entre 0 y 100 es de: " + sumar);
            Console.ReadKey();
        }
    }
}
