using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            float val, porcen, total;

            Console.Write("Digite o total da venda: ");
            val = float.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de acrécimo(sem simbolos ex: %): ");
            porcen = float.Parse(Console.ReadLine());

            total = ((porcen/100)*val)+val;

            Console.WriteLine($"Valor de venda é R$: {total}");
        }
    }
}