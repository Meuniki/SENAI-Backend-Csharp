using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] val1 = new float[10];
            float[] val2 = new float[10];
            float[] val3 = new float[10];

            for(int i=0;i<=9;i++){
                Console.Write("Digita um numero ai: ");
                val1[i] = float.Parse(Console.ReadLine());
            }
            for(int i=0;i<=9;i++){
                Console.Write("Digita outro numero ai: ");
                val2[i] = float.Parse(Console.ReadLine());
            }
            for(int i=0;i<=9;i++){
                val3[i] = (val1[i]+val2[i]);
                Console.WriteLine(val3[i]);
            }
        }
    }
}
