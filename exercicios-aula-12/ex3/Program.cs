using System;
using ex3.Controller;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();

            prod.CadastrarProduto();
            prod.MostrarProduto();
        }
    }
}
