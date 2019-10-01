using System;
using System.IO;
using aula_11.Models;

namespace aula_11.Controllers {
    public class ProdutosControllers {

        ProdutosModel produto = new ProdutosModel();

        public void CadastrarProdutos() {

            try {

                Console.WriteLine ("Digite o ID do Produto:");
                produto.IdProduto = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Digite o Nome do Produto: ");
                produto.NomeProduto = Console.ReadLine ();

                Console.WriteLine ("Digite a descrição do produto: ");
                produto.Descricao = Console.ReadLine ();

                Console.WriteLine ("Digite o preço do produto: ");
                produto.Preco = double.Parse (Console.ReadLine ());

                // Console.WriteLine ("Digite o ID do fornecedor: ");
                // produto.Fornecedor.IdFornecedor = int.Parse (Console.ReadLine ());

                // Console.WriteLine ("Digite o Nome do fornecedor: ");
                // produto.Fornecedor.NomeFornecedor = Console.ReadLine ();

            } catch(Exception ex) {
                Console.WriteLine("Desculpe :( Houve um erro na aplicação");
                SalvarErros(ex);

            }

        }

        public void ExibirProduto() {

            Console.WriteLine (produto.IdProduto);
            Console.WriteLine (produto.NomeProduto);
            Console.WriteLine (produto.Descricao);
            Console.WriteLine (produto.Preco);

            // Console.WriteLine (produto.Fornecedor.IdFornecedor);
            // Console.WriteLine (produto.Fornecedor.NomeFornecedor);

        }
        //Escrever arquivo de erro
        private void SalvarErros(Exception ex) {
            // Usando biblioteca nova StreamWrite serve para escrever/editar arquivos de texto
            StreamWriter txt = new StreamWriter("error_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex + "\n");

            txt.Close();

        }
    }
}