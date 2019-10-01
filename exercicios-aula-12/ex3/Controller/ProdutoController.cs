using System;
using System.IO;
using ex3.Models;

namespace ex3.Controller {
    public class ProdutoController {
        ProdutoModel produto = new ProdutoModel ();

        public void CadastrarProduto () {

            Console.Clear ();

            string resv = "";

            Console.Write ("Cadastre Produto: ");
            produto.Produto = Console.ReadLine ();

            System.Console.Write ("Deseja Reservar o Produto?: ");
            resv = Console.ReadLine ();

            resv = resv.Replace ("sim", "true");
            resv = resv.Replace ("yes", "true");
            resv = resv.Replace ("y", "true");
            resv = resv.Replace ("n", "false");
            resv = resv.Replace ("não", "false");
            resv = resv.Replace ("no", "false");

            try {
                if (resv == "true") {
                    produto.reservar = true;
                } else {
                    produto.reservar = false;
                }
            } catch (Exception ex) {
                System.Console.WriteLine ("Houve um erro :(");
                SalvarErros (ex);
            }

        }
        public void MostrarProduto () {

            System.Console.Write ($"O Produto {produto.Produto} ");
            if (produto.reservar == true) {
                System.Console.Write ("está reservado");
            } else {
                System.Console.Write ("não está reservado");
            }
        }

        private void SalvarErros (Exception ex) {
            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();
        }
    }
}