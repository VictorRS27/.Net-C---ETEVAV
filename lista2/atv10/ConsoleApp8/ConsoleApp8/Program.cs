using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv8
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, m, d;
            DateTime to, tf;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            Console.WriteLine("Digite a data do seu nascimento(ex.12/01/2004): ");
            to = Convert.ToDateTime(Console.ReadLine());
            tf = DateTime.Now;
            if(to.Month<30 && to.Month>0 && to.Day>0 && to.Day<31){
            if (to < tf)
            {
                a = tf.Year- to.Year;
                m = a*12 + (tf.Month-to.Month);
                d = a * 365 + (tf.Day - to.Day);
                Console.WriteLine("Você tem  "+a+" anos de vida, ou seja, "+m+ " meses, ou seja, " + d + " dias");
            }
            else
            {
                Console.WriteLine("então por acaso você não nasceu ainda???");
            }
            }
            Console.ReadKey();
        }
    }
}
