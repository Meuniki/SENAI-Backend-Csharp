using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            int tabu, resul;


            Console.Write("Ecreva um número: ");
            tabu = int.Parse(Console.ReadLine());

            for(int cont =1; cont<=10; cont++){
                
                resul = tabu * cont;
                Console.WriteLine($"{tabu}x{cont}= {resul}");

            }
            
            
        }
    }
}
