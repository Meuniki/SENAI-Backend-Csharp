using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;//Somente declaramos, sem atribuir valor
            
            int num2 = 5;// declaramos atribunindo um valor

            int num3, num4, num5;// decalramos diversas variaveis de mesmo tipo 

            float media;//float variavel do tipo decimal (real) trabalha no padrão americano

            bool resultado = false;// variavel do tipo lógico (booleana)

            string nomeAluno; //Variável do tipo texto(caracteres)

            Console.WriteLine();//Quebra linha

            Console.WriteLine("Bem vindos à nossa primeira aplicação!");//Escreve em uma lonha quebrando-a

            Console.Write("Digite");// Continua escrevendo na mesma loinha
            Console.Write("seu nome: ");
            

            nomeAluno = Console.ReadLine();// Captura o dado digitado pelo usuario e salvo na variavel

            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota:");//Concatenação

            num3 = int.Parse(Console.ReadLine());// Converto o texto capturado para o tipo inteiro

            //Interpolação

            Console.WriteLine($"Sua primeira nota é {num3}");

            Console.WriteLine("Digite sua segunda nota: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());

            media = (num3+num4+num5)/3;

            Console.WriteLine($"Sua média é: {media}");

        }
    }
}