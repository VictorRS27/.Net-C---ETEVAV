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
            int a, b, c, f;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            //Entrada de dados
            Console.WriteLine("Digite a nota do lab: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota da avaliação: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota do exame final: ");
            c = Convert.ToInt32(Console.ReadLine());

            f = (a * 2 + b * 3 + c * 5)/10;
        
            Console.WriteLine("seu nota final é:" + f);

            Console.ReadKey();
        }
    }
}