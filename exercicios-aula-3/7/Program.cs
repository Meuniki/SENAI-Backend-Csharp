using System;

namespace _7 {
    class Program {
        static void Main (string[] args) {
            int cont = 1, num, soma = 0;
            float mult = 1;

            while (cont <= 10) {

                Console.Write ("Digite um número: ");
                num = int.Parse (Console.ReadLine ());

                if (num % 2 != 0) {
                    soma += num;

                }
                if (num % 3 == 0) {
                    mult = mult * num;
                }
                cont++;
            }
            Console.Write ($"A soma é {soma} o produto é {mult}");
        }
    }
}