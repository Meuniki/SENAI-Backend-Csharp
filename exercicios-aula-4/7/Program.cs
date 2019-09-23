using System;

namespace _7 {
    class Program {
        static void Main (string[] args) {
            int[] val1 = new int[10];
            int comp   = 0, posi =0;

            for (int i = 0; i <= 9; i++) {
                Console.Write ("Digite um número: ");
                val1[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {

                if(i == 0){
                    comp = val1[i];
                }

                if (val1[i] > comp) {
                    comp = val1[i];
                    posi = i;
                }
            }

            Console.WriteLine($"O maior valor é {comp} o índice dele é {posi}");

        }
    }
}