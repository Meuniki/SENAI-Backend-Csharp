using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;

             Console.Write("Digite o primerio número:");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número:");
            n3 = int.Parse(Console.ReadLine());

            if(n1>n2 && n1>n3){
                Console.WriteLine($"O maior numero é {n1}");
            }else if(n2>n3){
                Console.WriteLine($"O maior numero é {n2}");
            }else{
                Console.WriteLine($"O maior numero é {n3}");
            }
        }
    }
}
