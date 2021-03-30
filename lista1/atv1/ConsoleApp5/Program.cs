using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{//1 - Escrever um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o seu nome, o salário fixo e salário no final do mês.

    class Program
    {
        static void Main(string[] args)
        {
            
            String nome;
            int salarioFixo, salarioTotal, totalVendas;
           
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o salario Fixo:");
            salarioFixo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas em dinheiro:");
            totalVendas = Convert.ToInt32(Console.ReadLine());
 
             salarioTotal = salarioFixo + (totalVendas/100*15);

            
            Console.WriteLine(nome + " salario total:" + salarioTotal + " salario fixo:" + salarioFixo);

            Console.ReadKey();
        }
    }
}
