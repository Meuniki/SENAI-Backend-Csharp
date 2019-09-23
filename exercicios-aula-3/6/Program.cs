using System;

namespace _6 {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Fibonacci.");

            int num1 = 0, num2 = 1;

            for(int i=0; i<=9; i++) {

                Console.WriteLine (num1);
                Console.WriteLine (num2);
                num1 += num2;
                num2 += num1;

            }
        }
    }
}