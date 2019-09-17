using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
           int numpedido;
           string pedido;

            Console.Write("Digite o numero do pedido: ");
            numpedido = int.Parse(Console.ReadLine());

            switch(numpedido){
                case 1:
                pedido = "Hamburger";
                break;

                case 2:
                pedido = "Cheese Salada";
                break;

                case 3:
                pedido = "Cheese burguer";
                break;

                case 4:
                pedido = "Cheese bacon";
                break;

                default:
                pedido = "Opção invalida";
                break;

            }
            Console.WriteLine(pedido);


        }
    }
}
