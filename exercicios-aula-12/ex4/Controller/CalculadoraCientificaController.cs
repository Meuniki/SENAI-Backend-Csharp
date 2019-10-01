using System;
using ex4.Models;

namespace ex4.Controller
{
    public class CalculadoraCientificaController : CalculadoraController
    {
        CalculadoraCientificaModel calcient = new CalculadoraCientificaModel();
         public void CalcularCin () {

            int operacao;

            Console.WriteLine ("\nDigite o número de que quer fazer? \n1-Adição \n2-Subtração \n3-Multiplicação \n4-Divisão \n5-Potência");
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
                case 5: {
                    potencia();
                    break;
                }
                default:{
                        System.Console.WriteLine ("Opção invalida!!");
                        break;
                    }

            }
            
        }
    }
}