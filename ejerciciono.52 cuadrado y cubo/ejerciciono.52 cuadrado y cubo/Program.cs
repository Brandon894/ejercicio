using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._52_cuadrado_y_cubo
{
    class Program
    {
        static double potencia;
        static int n, cuadrado, cubo;
        static void Main(string[] args)
        {
            n = 1;

            //operacion del cuadrado y cubo del 1 al 10
            while (n <= 10)
            {
                potencia = Math.Pow(n, 2); 
                cuadrado = Convert.ToInt32(potencia); 

                potencia = Math.Pow(n, 3);  
                cubo = Convert.ToInt32(potencia);  

                Console.WriteLine(n + " ; " + cuadrado + " ; " + cubo);  
                n = n + 1;  
            }
            Console.ReadKey();
        }
    }
}
