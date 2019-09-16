using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal, comi;
            double  total;

            Console.Write("Digite seu salário: R$");
            sal = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor total de suas vendas esse mês: R$");
            comi = float.Parse(Console.ReadLine());

            total = (comi*0.05)+sal;

            Console.WriteLine($"Seu salário esse mês é R$ {total}");
        }
    }
}
