using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv10
{
    class Program
    {
        static void Main(string[] args)
        {

            int i=0;
            double r=0, idou=0, x, x1=15,x2=225;

            do
            {
                i++;
                idou = Convert.ToDouble(i);
                r = r + idou / (idou * idou);
                r = r - (idou + 1) / ((idou + 1) * (idou + 1));

                i++;

            } while (i < 14);
            x = x1 / x2;
            /*sério que eu tive que salvar dois numeros em duas variaveis double só pq o computador não consegue dividir dois numeros e salvar numa variavel double*/
           r = r + x;
            Console.WriteLine("a resposta é:"+r);
            Console.ReadKey();
        }
    }
}
