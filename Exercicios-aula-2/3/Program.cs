using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;

            Console.Write("Digite o primerio número:");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            if(n1>n2){
                Console.WriteLine($"O mairo número é {n1}");
            }else{
                Console.WriteLine($"O mairo número é {n2}");
            }

        }
    }
}
