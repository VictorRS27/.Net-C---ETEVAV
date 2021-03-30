using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i, n;
            double r=1;

            do
            {
                r = 1;
                Console.WriteLine("Informe o numero a ser fatorado:");
                i = n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    while (i > 0)
                    {
                        r = r * i;
                        i--;
                    }
                }
                else
                {
                    while (i < 0)
                    {
                        r = r * i;
                        i++;
                    }
                }
                Console.WriteLine("o fatorial é "+r);
                Console.WriteLine("deseja tentar denovo");
                s = Console.ReadLine();
            } while (s == "S");
            Console.ReadKey();
        }
    }
}
