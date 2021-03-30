using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv7
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d;
            double r1, r2;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            Console.WriteLine("ax^2+bx+c=0"+"digite a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite b ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite b ");
            c = Convert.ToInt32(Console.ReadLine());
            d = b * b-4 * a * c;
                if (d < 0)
                {
                    a = a - b;
                    Console.WriteLine("o delta é negativo, não existe raiz real ");
                }
                else
                {
                    r1 = (-b + Math.Sqrt(d) )/ 2 * a;
                    r2 = (-b + Math.Sqrt(d) )/ 2 * a;
                    Console.WriteLine("as raizes são: "+r1+" e "+r2);
                }
            
            Console.ReadKey();
        }
    }
}

