using System;

namespace exercicios_aula_9 {
    class Program {
        static void Main (string[] args)
        {
            double valor, porcentagem;
            NewMethod(out valor, out porcentagem);

        }

        private static void NewMethod(out double valor, out double porcentagem)
        {

            // Criar uma função do tipo double que
            // recebe como argumentos valor e
            // porcentagem, onde o intuito é atribuir um desconto sobre a porcentagem e retornar
            // o valor aplicado o desconto
            try
            {
                System.Console.Write("Digite o valor do produto: R$");
                valor = double.Parse(Console.ReadLine());

                System.Console.Write("Digite o desconto:");
                porcentagem = double.Parse(Console.ReadLine().Replace("%", ""));

                System.Console.WriteLine(CalculaDesconto(valor, porcentagem));
            }
            catch (System ex)
            {
                System.Console.WriteLine("Os dados devem ser numéricos :( " + ex);

            }
        }

        /// <summary>
        ///  Função que calcula desconto para usuario
        /// </summary>
        /// <param name="valores"> valor do produto</param>
        /// <param name="desconto"> valor do desconto</param>
        /// <returns>Retorna o preço já com o desconto aplicado</returns>
        static double CalculaDesconto (double preco, double desconto) {

            return preco - (desconto / 100) * preco;
        }
    }
}