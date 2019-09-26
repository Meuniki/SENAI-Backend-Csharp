using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal, contas, total;

            Console.Write("Escrava slário: R$ ");
            sal = float.Parse(Console.ReadLine());

            Console.Write("Escreva o total das suas contas: R$ ");
            contas = float.Parse(Console.ReadLine());

            total= sal - contas;

            Console.Write($"Seu salário é {sal} e sobrou R${total}");
        }
    }
}
