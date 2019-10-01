using System;

namespace _2 {
    class Program {
        static void Main (string[] args) {
            //Criar uma função do tipo void que escreve no console o atual dia da semana
            // usando Datetime
            System.Console.Write("Hoje é dia: ");
            DiaDaSemana();
        }

        static void DiaDaSemana () {
            System.Console.WriteLine (DateTime.Now.Day.ToString());

        }
    }
}