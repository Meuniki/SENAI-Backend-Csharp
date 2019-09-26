using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {

        
            double n1,n2,n3,media;

            Console.Write("Digite nota 1: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digitr nota 2: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite nota 3: ");
            n3 = double.Parse(Console.ReadLine());

            media= (n1+n2+n3)/3;

            if(media >= 6){
                Console.WriteLine($"média de {media} aluno Aprovado");
            }else
                Console.WriteLine($"média de {media} aluno Reprovado");
            
        }
    }
}
