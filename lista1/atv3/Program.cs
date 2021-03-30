using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv3

    class Program
    {
        static void Main(string[] args)
        {
            
              double preco, percentual, valorf; 
            /* Tipos - String = Caracter
                       int    = int
                       bool   = booleana (true ou false)
                       Raeal  = double */

            //Entrada de dados
            Console.WriteLine("Digite o preco:");
            preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o percentual de lucro:");
            percentual = Convert.ToInt32(Console.ReadLine());

            valorf = preco+(preco/100*percentual);

            
            Console.WriteLine("seu novo preco é: " + valorf);

            Console.ReadKey();
        }
    }
}
