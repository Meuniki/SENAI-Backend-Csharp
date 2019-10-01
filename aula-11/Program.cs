using System;
using aula_11.Controllers;

namespace aula_11
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosControllers produto1 = new ProdutosControllers();

            produto1.CadastrarProdutos();
            produto1.ExibirProduto();
        }
    }
}
