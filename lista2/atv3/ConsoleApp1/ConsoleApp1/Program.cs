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

            
            double a, b, d;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            Console.WriteLine("Digite a sua altura: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o seu peso: ");
            b = Convert.ToDouble(Console.ReadLine());
            d = b / (a * a);
            Console.WriteLine("o resultado é: " + d+" ou seja ");

            if (d <= 18.5)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (d < 30)
            {
                Console.WriteLine("normal");
            }
            else if (d < 40)
            {
                Console.WriteLine("obeso");
            }
            else
            {
                Console.WriteLine("obeso mórbido");
            }

                Console.ReadKey();
            }
    }
}
