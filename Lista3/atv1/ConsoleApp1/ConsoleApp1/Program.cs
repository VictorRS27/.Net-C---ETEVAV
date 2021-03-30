using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i;

            Console.Write("digite um numero para a tabuada");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.Write(a+"x"+i+"="+a*i+"\n");
            }
            Console.ReadKey();
        }
    }
}
