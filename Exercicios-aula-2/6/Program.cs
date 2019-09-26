using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade<=9){
                Console.Write("Everyone");
            }else if(idade<=13){
                Console.Write("Everyone 10+");
            }else if(idade<=17){
                Console.Write("Teen");
            }else if(idade<18){
                Console.Write("Mature 17+");
            }else{
                Console.Write("Adults Only 18+");
            }
        }
    }
}
