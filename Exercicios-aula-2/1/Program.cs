using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal, desp, total;
            string final;

            Console.Write("Digite seu salário: R$");
            sal = float.Parse(Console.ReadLine());

            Console.Write("Digite suas despesas: R$");
            desp = float.Parse(Console.ReadLine());

            total = sal-desp;

            if(total<0){
                final = "déficit";
            }else{
                final = "superávit";
            }

            Console.WriteLine($"Você está em um {final} de R${total}");

        }
    }
}
