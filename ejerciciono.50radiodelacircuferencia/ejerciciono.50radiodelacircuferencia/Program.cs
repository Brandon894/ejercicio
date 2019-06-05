using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._50radiodelacircuferencia
{
    class Program
    {
        static string entrada;
        static float radio, PI;
        static void Main(string[] args)
        {
            PI = 3.1416f;

            Console.WriteLine("Ingrese el radio de la circunferencia: ");
            entrada = Console.ReadLine();
            radio = Convert.ToSingle(entrada);
           
            Console.WriteLine("El diámetro es de: " + (radio / PI));

            Console.WriteLine("El área es de: " + (PI * (radio * radio)));

            Console.WriteLine("La circunferencia es de: " + ((2 * PI) * radio));

            Console.ReadKey();
        }
    }
}
