using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,mult;

            Console.Write("Digite o número: ");
            n1 = int.Parse(Console.ReadLine());

            mult = (n1*3);

            Console.WriteLine($"O triplo de {n1} é {mult}");
        }
    }
}
