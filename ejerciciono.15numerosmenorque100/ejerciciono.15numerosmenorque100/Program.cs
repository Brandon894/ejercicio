using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._15numerosmenorque100
{
    class Program
    {
        static int potencia;
        static string entrada;
        static float n, sumar, numero;
        static double dato;
        static void Main(string[] args)
        {
            n = 0;  
            entrada = "";  
            numero = 0;

            ingresodenumerosmenoresque100();
            cuadradosDeNumeros4Posiciones();
        }

        static public void ingresodenumerosmenoresque100()
        {
            Console.WriteLine("Ingrese un número menor que 100: "); 
            entrada = Console.ReadLine(); 
            numero = Convert.ToSingle(entrada); 

            while (n > 100)  
            {
                Console.WriteLine("El número ingresado es mayor que 100, ingrese un número menor que 100: "); 
                entrada = Console.ReadLine(); 
                numero = Convert.ToSingle(entrada);  
            }
        }

        static public void cuadradosDeNumeros4Posiciones()
        {
            n = numero;  
            while (n <= 100) 
            {
                dato = Math.Pow(n, 2);  
                potencia = Convert.ToInt32(dato); 
                Console.WriteLine(n); 
                sumar = sumar + potencia;  
                n = n + 4;  
            }

            Console.WriteLine("La suma de los cuadrados de los numeros que estan separados entres sí cuatro posiciones es de: " + sumar);
            Console.ReadKey();
        }
    }
}
