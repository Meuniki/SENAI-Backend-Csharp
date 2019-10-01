using System;
using ex4.Models;

namespace ex4.Controller {
    public class CalculadoraController {
        CalculadoraModel calc = new CalculadoraModel ();
        public void Calcular () {

            int operacao;

            Console.WriteLine ("\nDigite o número de que quer fazer? \n1-Adição \n2-Subtração \n3-Multiplicação \n4-Divisão");
            operacao = int.Parse (Console.ReadLine ());

            switch (operacao) {
                case 1:{
                        Somar ();
                        break;
                    }
                case 2: {
                        Subtração ();
                        break;
                    }
                case 3:{
                        Mult ();
                        break;
                    }
                case 4: {
                        div();
                        break;
                    }
                default:{
                        System.Console.WriteLine ("Opção invalida!!");
                        break;
                    }

            }
        }
        public void Somar () {

            double n1, n2;
            System.Console.WriteLine ("Digite o primeiro número");
            n1 = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o segundo número");
            n2 = double.Parse (Console.ReadLine ());
            calc.Adicao = n1 + n2;
            System.Console.WriteLine ($"O resultado da sua soma é: {calc.Adicao}");

        }
        public void Subtração () {

            double n1, n2;
            System.Console.WriteLine ("Digite o primeiro número");
            n1 = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o segundo número");
            n2 = double.Parse (Console.ReadLine ());
            calc.Subtracao = n1 - n2;
            System.Console.WriteLine ($"O resultado da sua Subtração é: {calc.Subtracao}");
        }
        public void Mult () {

            double n1, n2;
            System.Console.WriteLine ("Digite o primeiro número");
            n1 = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o segundo número");
            n2 = double.Parse (Console.ReadLine ());
            calc.Multiplicacao = n1 * n2;
            System.Console.WriteLine ($"O resultado da sua Multiplicacao é: {calc.Multiplicacao}");
        }
        public void div () {

            double n1, n2;
            System.Console.WriteLine ("Digite o primeiro número");
            n1 = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite o segundo número");
            n2 = double.Parse (Console.ReadLine ());
            calc.Divicao = n1 / n2;
            System.Console.WriteLine ($"O resultado da sua Divisão é: {calc.Divicao}");
        }

    }
}