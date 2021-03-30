using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, nv="-", nn="-", no;
            int i=0, v=0, n=0, f;

            do
            {
                i++;
                Console.WriteLine("digite o nome");
                no = Console.ReadLine();
                Console.WriteLine("digite a idade");
                f = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    v = f;
                    nv = no;
                    n = f;
                    nn = no;
                }
                if (f > v)
                {
                    v = f;
                    nv = no;
                }
                if (f < n)
                {
                    n = f;
                    nn = no;
                }
                Console.WriteLine("digite s para mais um nome");
                s = Console.ReadLine();
            } while (s == "S");
            Console.WriteLine("o mais velho chama: "+nv+" e tem "+v+" anos enquanto o mais novo chama: "+nn+" e tem "+n+" anos dentre "+i+" registrados");


            Console.ReadKey();
        }
    }
}
