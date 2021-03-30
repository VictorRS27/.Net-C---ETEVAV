using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String nome;
            double nota1, nota2, nota3, media;
            
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");







            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3 = Convert.ToInt32(Console.ReadLine());

            
            media = (nota1+nota2+nota3)/3;

            
            Console.WriteLine(nome + " sua nota é: " + media);

            Console.ReadKey();
        }
    }
}