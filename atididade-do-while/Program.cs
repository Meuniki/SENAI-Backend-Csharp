using System;

namespace atididade_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, cont = 1, acum = 0;

            do{

                cont++;
                Console.Write($"Digite um número:");
                num = int.Parse(Console.ReadLine());

                if(num %2 != 0){
                    acum += num;
                }

            }while(cont<=20);
            Console.WriteLine($"A soma de todos impares é: {acum}");
        }
    }
}
