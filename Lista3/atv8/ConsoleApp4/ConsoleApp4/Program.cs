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

            int i = 0, h = 0, m = 0, a, o = 0, ti=0, h50=0, mj=0,smv=0,smn=0,tc = 0;
            string f, e;
            double pc;

            do
            {
                i++;
                Console.WriteLine("digite M para homem e F para mulher");
                f = Console.ReadLine();
                Console.WriteLine("digite (s/n) para experiência");
                e = Console.ReadLine();
                Console.WriteLine("digite sua idade");
                a = Convert.ToInt32(Console.ReadLine());
                if (f == "m" || f == "M")
                {
                    if (a > 50)
                    {
                        h50++;
                    }
                    h++;
                }
                else if (f == "f" || f == "F")
                {
                    if(a<30 && (e == "s" || e == "S"))
                    {
                        if (i == 1)
                        {
                            smv = a;
                            smn = a;
                        }
                        if (a > smv)
                        {
                            smv = a;
                        }
                        if (a < smn)
                        {
                            smn = a;
                        }
                        mj++;

                    }
                    m++;
                }
                else
                {
                    Console.WriteLine("genero errado");
                    o++;
                }

                if (e == "s" || e == "S")
                {
                    ti = a;
                    tc++;
                }
                else if (f == "n" || f == "N")
                {
                    Console.WriteLine("mulher");
                    m++;
                }
                else
                {
                    Console.WriteLine("genero errado");
                    i--;
                }
            } while (i <= 50);
            pc = h50 / h * 100;
            ti = ti / tc;

            Console.WriteLine("tiveram " + m + " candidatas e " + h + " candidatos e "+o+"outros\nA media de iade dos candidatos com experiencia é: "+ti+"\n"+pc+"% dos homens tem mais de 50 anos\n"+mj+"são mulheres abaixo de 30 com experiencia\nDentre essas mulheres a mais velha tem "+smv+" e a mais nova tem "+smn);


            Console.ReadKey();
        }
    }
}