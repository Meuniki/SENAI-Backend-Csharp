using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;

            Console.Write("Insira o valor total: R$");
            preco = float.Parse(Console.ReadLine());

            if(preco >= 100 && preco<=1000){
                preco = preco-(preco * 0.15);
            }

            Console.WriteLine($"Preço total é R${preco}");
        }
    }
}
