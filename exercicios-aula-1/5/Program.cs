using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal, comi;
            double  total;
            string nome;

            Console.Write("Qual seu nome parceiro? :");
            nome = Console.ReadLine();

            Console.Write("Digite seu salário: R$");
            sal = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor total de suas vendas esse mês: R$");
            comi = float.Parse(Console.ReadLine());

            total = (comi*0.1)+sal;

            Console.WriteLine($"sr(a){nome} seu salário esse mês é de R$ {sal}, mais as comissões fica R$ {total}");
        }
    }
}
