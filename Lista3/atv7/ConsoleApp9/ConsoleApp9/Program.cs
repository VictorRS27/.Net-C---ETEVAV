using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, pc, pv, r;

            for (i = 0; i < 40; i++)
            {

                Console.WriteLine("digite o preço de custo");
                pc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite o preço de venda");
                pv = Convert.ToInt32(Console.ReadLine());
                if (pc == pv)
                {
                    Console.WriteLine("empate");
                }
                else if (pc <= pv)
                {
                    r = pv - pc;
                    Console.WriteLine("lucro de " + r + " reais");
                }
                else
                {
                    r = pc - pv;
                    Console.WriteLine("prejuizo de " + r + " reais");
                }
            }

            Console.ReadKey();
        }
    }
}
