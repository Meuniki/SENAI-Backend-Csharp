using System;

namespace _3 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[12];
            string[] cor = new string[12];
            int[] tamanho = new int[12];
            double[] preco = new double[12];

            for (int i = 0; i <= 11; i++) {

                Console.Write ("Digite o nome do produto:");
                nome[i] = Console.ReadLine ();

                Console.Write ("Digite a cor do produto:");
                cor[i] = Console.ReadLine ();

                Console.Write ("Digite o tamanho do produto:");
                tamanho[i] = int.Parse (Console.ReadLine ());

                Console.Write ("Digite o preço do produto:");
                preco[i] = double.Parse (Console.ReadLine ());
            }

            for (int i = 0; i <= 11; i++) {

                Console.WriteLine (nome[i]);
                Console.WriteLine (cor[i]);
                Console.WriteLine (tamanho[i]);
                Console.WriteLine (preco[i]);

            }

        }
    }
}