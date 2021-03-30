using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,n = 0,l;

            do
            {
                i++;
                Console.WriteLine("digite o"+i+"° numero");
                l = Convert.ToInt32(Console.ReadLine());
                if (l>10 && l<150)
                {
                    n++;
                }
            } while (i < 80);
            Console.WriteLine("Dentre os 80 numeros, " + n + " deles estão entre 10 e 150");


            Console.ReadKey();
        }
    }
}
