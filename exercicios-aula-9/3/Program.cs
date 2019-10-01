using System;

namespace _3 {
    class Program {
        static void Main (string[] args) {

            string nome, sobrenome, idade, peso, altura;

            //  Criar uma sobrecarga de métodos chamada MostraInfo onde:
            //  a) 1 - Sem argumentos, escreve no console a razão social da escola Senai de
            // Informática
            //  b) 2 - Com dois argumentos, retorna seu nome é sobrenome
            //  c) 3 - Com três argumentos, retorna sua idade, peso e altura
            
            Console.Write ("Digite seu nome: ");
            nome = Console.ReadLine ();

            System.Console.Write ("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine ();

            System.Console.Write ("Digite sua idade: ");
            idade = Console.ReadLine ();

            System.Console.Write ("Digite seu peso: ");
            peso = Console.ReadLine ();

            System.Console.Write ("Digite sua altura: ");
            altura = Console.ReadLine ();
        
            if (nome != "" && sobrenome != "") {

                System.Console.WriteLine (MostraInfo (nome, sobrenome));

            } else if (idade != "" && peso != "" && altura != "") {

                System.Console.WriteLine (MostraInfo (idade, peso, altura));

            } else {
                System.Console.WriteLine (MostraInfo ());
            }
        }
        static string MostraInfo () {

            return "Serviço nacional de aprendizem industrial";
        }

        static string MostraInfo (string nome, string sobrenome) {
             
            return nome + " " + sobrenome;
        }

        static string MostraInfo (string idade, string peso, string altura) {
            return $"{idade} {peso} {altura}";
        }
    }
}