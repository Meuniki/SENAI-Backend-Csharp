using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] val_1 = new string[15];
            string[] val_2 = new string[15];
            string[] val_3 = new string[30];
            for (int i=0; i<=9; i++) {
                Console.Write ("Escreva algo: ");
                val_1[i] = Console.ReadLine ();
            }
            for (int i=0; i<=9; i++) {
                Console.Write ("Escreva algo de novo: ");
                val_2[i] = Console.ReadLine ();
            }
            for (int i=0; i<=9; i++) {
                val_3[i] = val_1[i];
                val_3[i+10] = val_2[i];
            }
            for (int i=0; i<=19; i++) {
                Console.WriteLine (val_3[i]);
            }
        }
    }
}
