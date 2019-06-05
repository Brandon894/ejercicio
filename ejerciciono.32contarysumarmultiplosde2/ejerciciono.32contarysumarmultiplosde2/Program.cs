using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._32contarysumarmultiplosde2
{
    class Program
    {
        static string entrada;
        static int n, contar;
        static float dato1, dato2, sumar;
        static void Main(string[] args)
        {
            proceso();
            multiplosde2();
        }
        static public void proceso()
        {
            Console.WriteLine("Ingrese un número: ");  
            entrada = Console.ReadLine(); 
            dato1 = Convert.ToSingle(entrada); 
            n = Convert.ToInt32(dato1);  

            Console.WriteLine("Ingrese un número mayor que: " + dato1);  
            entrada = Console.ReadLine();  
            dato2 = Convert.ToSingle(entrada);  

            while (dato2 < dato1)
            {
                Console.WriteLine("El número ingresado es menor que: " + dato1 + " ingrese nuevamente un número mayor que " + dato1);   
                entrada = Console.ReadLine();  
                dato2 = Convert.ToSingle(entrada);
            }
        }
        static public void multiplosde2()
        {
            while (n <= dato2) 
            {
                if (n % 2 == 0)  
                {
                    Console.WriteLine(n);  
                    sumar = sumar + n; 
                    contar = contar + 1;  
                }             
                n= n + 1;  
            }
            Console.WriteLine("Hay un total de " + contar + " múltiplos de 2");
            Console.WriteLine("La suma de los múltiplos de 2 es de " + sumar);
            Console.ReadLine();
        }
    }
}
