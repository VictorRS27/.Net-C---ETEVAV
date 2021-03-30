using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, f;

            do
            {
                i++;
                Console.WriteLine("digite a idade");
                f = Convert.ToInt32(Console.ReadLine());
                if (f > 18)
                {
                    Console.WriteLine("maior");
                }
                else if(f < 0)
                {
                    Console.WriteLine("então não nasceu ainda");
                }
                else
                {
                    Console.WriteLine("menor5");
                }
            } while (i <= 75);


            Console.ReadKey();
        }
    }
}

