using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10]; 
            float n2 = 0;

            for(int i=0; i<=9; i++){
                Console.Write("Digite os valores: ");
                n1[i] = int.Parse(Console.ReadLine());
            }

            n2 = n1[9]*5;
            Console.WriteLine();
            Console.WriteLine($"{n2} multiplicado por 5 é: {n2}");

        }
    }
}
