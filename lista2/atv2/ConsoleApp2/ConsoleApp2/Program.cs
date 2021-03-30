using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, d;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            Console.WriteLine("Digite a primeiro numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a>=b) { 
                    d = a - b;
                    Console.WriteLine("o resultado é:" + d);
            }else{
                d = b - a;
                Console.WriteLine("o resultado é:" + d);
            }
            Console.ReadKey();
        }
    }
}