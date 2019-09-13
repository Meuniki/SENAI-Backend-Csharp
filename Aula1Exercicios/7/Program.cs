using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int pax;
            double total;

            Console.Write("Quntos passageiros? : ");
            pax = int.Parse(Console.ReadLine());

            total = pax* 4.20;
            Console.WriteLine($"Você arrecadou R${total}");
        }
    }
}
