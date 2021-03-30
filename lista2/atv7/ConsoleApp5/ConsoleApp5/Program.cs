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

            int a, b, i;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            Console.WriteLine("Digite saldo atual: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 3; i++) { 
            Console.WriteLine("Digite valor do debito: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a >= b )
            {
                a = a - b;
                Console.WriteLine("o novo saldo é: "+a);
            }
            else 
            {
                Console.WriteLine("não foi possivel fazer o debito");
            } 
            }
            Console.ReadKey();
        }
    }
}

