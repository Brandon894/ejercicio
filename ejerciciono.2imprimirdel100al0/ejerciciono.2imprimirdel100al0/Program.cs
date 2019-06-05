using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciono._2imprimirdel100al0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            while (n>=0)
            {
                Console.WriteLine(n);
                n = n - 1;
            }
            Console.ReadKey();

        }
    }
}
