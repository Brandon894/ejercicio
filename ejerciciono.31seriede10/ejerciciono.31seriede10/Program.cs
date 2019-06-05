using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._31seriede10
{
    class Program
    {
        static int n, serie;
        static void Main(string[] args)
        {
            while (serie <= 10)
            {
                n = 1;
                while (n <= 10)
                {
                    Console.WriteLine(n);

                    n = n + 1;
                }
                serie = serie + 1;
            }

            Console.ReadKey();
        }
    }
}
