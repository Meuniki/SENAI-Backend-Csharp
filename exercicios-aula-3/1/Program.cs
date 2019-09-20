using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            double num;

            for(int cont=1; cont<= 100; cont++){

                num = Math.Pow(cont,3);
                
                Console.WriteLine(num);
            }
        }
    }
}
