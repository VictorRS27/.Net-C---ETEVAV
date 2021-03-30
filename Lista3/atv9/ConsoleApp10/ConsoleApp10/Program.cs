using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, n, sint=0, d=0, ma=0, me=0, cubo=0;
            double m=0, cu=0, impar=0, sdou=0;

            while (i < 50)
            {
                i++;
                Console.WriteLine("digite o "+i+"° numero");
                n = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    sdou = sint = ma = me = n;
                }
                else
                {
                    sint = sint + n;
                    sdou = sdou + n;
                }
                if (n < me)
                {
                    me = n;
                }
                if (n > ma)
                {
                    ma = n;
                }
                if (n % 2 == 1)
                {
                    impar++;
                }
            }
            m = sdou / 4;
            d = sint * 2;
            cubo = sint * sint * sint;
            cu = impar/50*100;
            Console.WriteLine("soma:"+sint+" dobro:"+d+" cubo:"+cubo+" media:"+m+" maior:"+ma+" menor:"+me+" porcentagem de ímpares:"+cu+"%");
            Console.ReadKey();
        }
    }
}