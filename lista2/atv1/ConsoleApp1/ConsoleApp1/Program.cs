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
            string o;
            double a, b, d;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            //Entrada de dados
            Console.WriteLine("Digite a primeiro numero: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite M para multiplicação, D para divisão, S para soma ou A para subtração ");
            o = Console.ReadLine();

            switch (o) 
               {
          case "D":
                    if(b==0){
                        Console.WriteLine("0 n pode fdp");
                    }else {
                        d = a / b;
                        Console.WriteLine("o resultado é:"+d);
                    }
                break;
          case "A":
                    d = a - b;
                    Console.WriteLine("o resultado é:" + d);
                break;
          case "M":
                    d = a * b;
                    Console.WriteLine("o resultado é:" + d);
               break; 
          case "S":
                    d = a + b;
                    Console.WriteLine("o resultado é:" + d);
               break;
                default:
              Console.WriteLine("n digitou direito fdp");
                break;
            }
            Console.ReadKey();
        }
    }
}