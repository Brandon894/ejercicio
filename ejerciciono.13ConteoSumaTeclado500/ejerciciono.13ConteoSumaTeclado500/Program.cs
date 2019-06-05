using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._13ConteoSumaTeclado500
{
    class Program
    {
        static string entrada;
        static float n, sumar, numero;
static int contar;
        static void Main(string[] args)
        {
            n = 0;  
            contar = 0;  
            sumar = 0; 
            numero = 0; 
            entrada = "";  

            numeroIngresadoMenorQue500();
            sumaryContar8PosicionesHasta500();
          
        }

        static public void numeroIngresadoMenorQue500()
        {
            Console.WriteLine("Ingrese un número menor que 500: ");  
            entrada = Console.ReadLine();  
            numero = Convert.ToSingle(entrada);  

            while (numero >= 500)  
            {
                Console.WriteLine("El número ingresado es mayor que 500, ingrese un número menor que 500: "); 
                entrada = Console.ReadLine();
                numero = Convert.ToSingle(entrada);  

            }
        }

        static public void sumaryContar8PosicionesHasta500()
        {
            n = numero;
            while (n <= 500)
            {
                Console.WriteLine(n);
                sumar = sumar + n;
                n = n + 8;
                contar = contar + 1;
            }

            Console.WriteLine("Hay un total de: " + contar + " numeros desde " + numero + " hasta 500 separados en 8 posiciones"); 
            Console.WriteLine("La suma total es de: " + sumar);
            Console.ReadKey();
        }
    }
}
