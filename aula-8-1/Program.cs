using System;

namespace aula_8_1 {
    class Program {
        static void Main (string[] args) {
            int numero;

            try {
                // Escrevemos um bloco de código
                Console.WriteLine ("Digite um número");
                numero = int.Parse (Console.ReadLine ());
            } catch (Exception ex) {
                // Mostramos a exeção da regra
                // Erro gerado na aplicação
                System.Console.WriteLine ("Ops :( Deu ruim. Erro: "+ ex );
            }
        }
    }
}