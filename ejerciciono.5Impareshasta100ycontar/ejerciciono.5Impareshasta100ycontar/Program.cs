using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._5Impareshasta100ycontar
{
    class Program
    {
        static int n, contar;
        static void Main(string[] args)
        {
            n = 1;
            contar = 0;
            numimpareshasta100ycontar();
            
        }
        static private void numimpareshasta100ycontar()
        {
            while (n <= 100)
            {
                Console.WriteLine(n);
                n = n + 2;
                contar = contar + 1;
            }
            Console.WriteLine("Hay un total de " + contar + "numeros impares");
            Console.ReadKey();
        }
       
    }
    }
        
