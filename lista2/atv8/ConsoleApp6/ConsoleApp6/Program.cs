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

            int a, b, i;
            DateTime to, tf;
            System.TimeSpan tx;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            Console.WriteLine("Digite a hora de inicio(ex.12:30): ");
            to = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite a hora de termino: ");
            tf = Convert.ToDateTime(Console.ReadLine());
            
            if (to>tf)
            {
                tf= tf.AddDays(1);
                tx = tf.Subtract(to);
            }
            else
            {
                tx = tf.Subtract(to);
            }
        
                    Console.WriteLine(tx);

            Console.ReadKey();
        }
    }
}

