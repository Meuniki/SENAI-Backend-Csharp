using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Definimos as variaveis que ultilizaremos para o cálculo
            float n1,n2,n3,media;
            string resultado;

            Console.Write("Digite nota 1: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Digitr nota 2: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite nota 3: ");
            n3 = float.Parse(Console.ReadLine());

            media= (n1+n2+n3)/3;

            if(media >= 6){
                resultado = "Aprovado";
            }else if(media < 6 && media >= 4){
                resultado = "de Recuperação";
            }else{
                resultado = "Reprovado";
            }
            Console.WriteLine($"média de {media} .O aluno está {resultado}");
        }
    }
}