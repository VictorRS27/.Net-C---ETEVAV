using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool s;
            double a, b, c, d;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

                Console.WriteLine("Digite a primeira nota: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota: ");
                c = Convert.ToDouble(Console.ReadLine());
                d = (a + b + c) / 3;
                Console.WriteLine("o nota é: " + d + " ou seja ");
                Math.Round(value: d, digits: 2);
                if (d >= 7)
                {
                    Console.WriteLine("Aprovado");
                }
                else if (d < 5)
                {
                    Console.WriteLine("Reprovado");
                }
                else if (d < 6.9 || d > 5.1)
                {
                    Console.WriteLine("Recuperação");
                }
                else
                {
                    Console.WriteLine("digite uma nota valida");
                }
            Console.ReadKey();
        }
    }
}
