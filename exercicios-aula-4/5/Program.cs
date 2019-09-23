using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] val = new int[10];

            for(int i=0;i <=9; i++){
            Console.Write("Digita um numero ai: ");
            val[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i <=9; i++){

            Console.WriteLine(val[i]*2);
            }
        }
    }
}
