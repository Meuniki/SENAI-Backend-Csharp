using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, cont2 = 0;
            float num, med = 0;

            do{
                Console.Write("Digite um número: ");
                num = float.Parse(Console.ReadLine());
                
                cont++;

                if( num>0 ){
                    Console.WriteLine(num);
                }else{
                    cont2++;
                    med += num;
                }

            }while(cont <= 20);{
                Console.WriteLine($"A média dos número negativos é: {med/cont2}");
            }
                        
        }
    }
}
