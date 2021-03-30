using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv6
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, h = 0, m = 0; 
            string f;

            do
            {
                i++;
                Console.WriteLine("digite M para homem e F para mulher");
                f = Console.ReadLine();
                if (f == "m"||f == "M")
                {
                    Console.WriteLine("homem");
                    h++;
                }
                else if (f == "f" || f == "F")
                {
                    Console.WriteLine("mulher");
                    m++;
                }
                else
                {
                    Console.WriteLine("genero errado");
                    i--;
                }
            } while (i <= 56);

            Console.WriteLine("tiveram "+m+" mulheres e "+h+" homens");

            Console.ReadKey();
        }
    }
}