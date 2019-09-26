using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            float real, dolar, result;

            Console.Write("Coloque a cotação do dolar: U$ ");
            dolar = float.Parse(Console.ReadLine());

            Console.Write("Quanto você quer converter: R$ ");
            real = float.Parse(Console.ReadLine());

            result = real/dolar;

            Console.Write($"A conversão é de R$ {real} da U$ {result}");

        }
    }
}
