using System;

namespace _6 {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Fibonacci.");

            int num1 = 0, num2 = 1, cont = 0;

            Console.WriteLine (num1);
            Console.WriteLine (num2);

            while (8 >= cont) {

                num1 += num2;
                num2 += num1;
                Console.WriteLine (num1);
                Console.WriteLine (num2);
                cont++;

            }
        }
    }
}