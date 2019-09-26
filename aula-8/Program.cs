using System;

namespace aula_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v1 = {"A", "B", "C"};

            //Laço FOREACH (para cada)
            foreach (var item in v1){
                Console.WriteLine(item);
            }
        }
    }
}
