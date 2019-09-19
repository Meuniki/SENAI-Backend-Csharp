using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, peso_relativo;
            string planeta;

            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um dos números relativo aos planetas a seguir");

            Console.WriteLine("1 - Mercúrio");
            Console.WriteLine("2 - Vênus");
            Console.WriteLine("3 - Marte");
            Console.WriteLine("4 - Júpter");
            Console.WriteLine("5 - Saturno");
            Console.WriteLine("6 - Urano");
            planeta = Console.ReadLine();

            switch(planeta){

                case "1":
                peso_relativo = peso*0.37;
                Console.WriteLine($"Seu peso em Mercúrio é de {peso_relativo}Kg");
                break;

                case "2":
                peso_relativo = peso*0.88;
                Console.WriteLine($"Seu peso em Vênus é de {peso_relativo}Kg");
                break;

                case "3":
                peso_relativo = peso*0.38;
                Console.WriteLine($"Seu peso em Marte é de {peso_relativo}Kg");
                break;

                case "4":
                peso_relativo = peso*2.64;
                Console.WriteLine($"Seu peso em Júpter é de {peso_relativo}Kg");
                break;

                case "5":
                peso_relativo = peso*1.15;
                Console.WriteLine($"Seu peso em Saturno é de {peso_relativo}Kg");;
                break;

                case "6":
                peso_relativo = peso*1.17;
                Console.WriteLine($"Seu peso em Urano é de {peso_relativo}Kg");
                break;

                default:
                peso_relativo = 00.00;
                break;
                
            }


        }
    }
}
