using System;

namespace _3 {
    class Program {
        static void Main (string[] args) {

            int num;

            Console.Write ("Digite um número: ");
            num = int.Parse (Console.ReadLine ());

            for (int i = 1; num >= i; i++) {
                
                if (i % 5 == 0) {

                    Console.WriteLine (i);
                }
            }

        }
    }
}