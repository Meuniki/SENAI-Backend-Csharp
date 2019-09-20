using System;

namespace _5 {
    class Program {
        static void Main (string[] args) {
            int    fun, cont = 0;
            double sal = 0, med = 0;

            Console.Write ("Digite a quantidade de funcionários: ");
            fun = int.Parse (Console.ReadLine ());
            do {

                Console.Write("Digite  salário: R$");
                sal = double.Parse(Console.ReadLine());
                med += sal; 
                cont++;
                
            } while (cont != fun); {

                Console.WriteLine($"A média salarial dos seus {fun} funcionários é de R${med/cont} ");
            }
        }
    }
}