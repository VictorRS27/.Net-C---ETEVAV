using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4
{
    class Program
    {
        static void Main(string[] args)
        {

            double preco, comimposto, valorf;
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            //Entrada de dados
            Console.WriteLine("Digite o preco:");
            preco = Convert.ToDouble(Console.ReadLine());

            comimposto = preco + (preco / 100 * 45);
            valorf = comimposto + (comimposto / 100 * 28);


            Console.WriteLine("seu novo preco é: " + valorf);

            Console.ReadKey();
        }
    }
}