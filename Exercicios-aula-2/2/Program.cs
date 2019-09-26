using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco;

            Console.Write("Insire uo preço total: R$");
            preco = float.Parse(Console.ReadLine());

            if(preco > 100){
                preco -= 25;  
            }

            Console.WriteLine($"Preço total é R${preco}");
        }
    }
}
