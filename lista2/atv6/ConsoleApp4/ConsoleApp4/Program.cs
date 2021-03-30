using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    class Program
    {
        static void Main(string[] args)
        {

            int d;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            Console.WriteLine("Digite um numero para módulo: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (d < 0)
            {
                d = d - 2 *d;
            }

            Console.WriteLine("o módulo é : |"+d+"|");
            Console.ReadKey();
        }
    }
}

