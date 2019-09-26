using System;

namespace aula3 {
    class Program {
        static void Main (string[] args) {

            //LAÇO CONTADO - FOR - INCREMENTO (+)
            for (int cont = 0; cont <= 100; cont++) {
                if (cont % 2 != 0) {

                    //Verificamos se o número é diferente de par
                    Console.WriteLine ("FOR 0-100 - " + cont);
                }
            }

            //LAÇO CONTADO - FOR - DECREMENTO (-)
            for (int cont2 = 100; cont2 >= 0; cont2--) {
                if (cont2 % 2 != 0) {

                    //Verificamos se o número é diferente de par
                    Console.WriteLine ("FOR 100-0 - " + cont2);
                }
            }

            //laço condicional - while

            double acumuladora = 0;
            double nota        = 0;
            int    cont3        = 0;
            string sair        = "";

            while (sair != "sim") {

                Console.WriteLine("Digite a nota de um aluno: ");
                acumuladora = double.Parse(Console.ReadLine ());

                acumuladora += nota;
                cont3++;

                Console.Write("Deseja sair da apliacação? sim/não ");
                sair = Console.ReadLine().ToLower();

            }
            Console.WriteLine($"Média das notas: {acumuladora / cont3}");
            
            

        }
    }
}