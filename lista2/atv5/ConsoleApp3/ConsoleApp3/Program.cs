using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
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

            Console.WriteLine("Digite a sua idade: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (d <=7 && d>=5)
            {
                Console.WriteLine("infantil A");
            }
            else if (d <= 10 && d >= 8)
            {
                Console.WriteLine("infantil B");
            }
            else if (d <= 13 && d >= 11)
            {
                Console.WriteLine("junvenil A");
            }
            else if(d <= 17 && d >= 14)
            {
                Console.WriteLine("junvenil B");
            }
            else if (d <= 25 && d >= 18)
            {
                Console.WriteLine("senior");
            }
            else
            {
                Console.WriteLine("fora da faixa etaria");
            }
            Console.ReadKey();
        }
    }
}

