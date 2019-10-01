using System;
using System.IO;
using exercicios_aula_11_POO.Models;

namespace exercicios_aula_11_POO.Controllers {
    public class PessoasControllers {
        PessoaModel pessoa = new PessoaModel ();

        public void CadastrarPessoa () {

            Console.Clear ();

            Console.Write ("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine ();

            try {
                Console.Write ("Digite sua Idade: ");
                pessoa.Idade = int.Parse (Console.ReadLine ());
            } catch (Exception ex) {
                Console.WriteLine ("Ops.. ouve um erro :(");
                SalvarErros (ex);
            }
            try {

                Console.Write ("Digite seu peso: ");
                pessoa.Peso = Double.Parse (Console.ReadLine ());

                Console.Write ("Digite sua altura: ");
                pessoa.Altura = Double.Parse (Console.ReadLine ());

            } catch (Exception ex) {
                System.Console.WriteLine ("Ops.. ouve um erro :(");
                SalvarErros (ex);
            }

        }

        public void ExibirDados () {

            Console.Clear ();

            System.Console.WriteLine ($"\n{pessoa.Nome}\n{pessoa.Idade}\n{pessoa.Peso}\n{pessoa.Altura} ");
            double IMC;

            IMC = pessoa.Peso / (Math.Pow (pessoa.Altura, 2));

            if (IMC < 18.5) {
                System.Console.WriteLine ($"seu IMC é {IMC} você está: Abaixo do peso");
            } else if (IMC >= 18.5 && IMC < 25) {
                System.Console.WriteLine ($"seu IMC é {IMC} você está: Peso normal");
            } else if (IMC >= 26 && IMC < 31) {
                System.Console.WriteLine ($"seu IMC é {IMC} você está: Sobrepesol");
            } else if (IMC > 30 && IMC < 36) {
                System.Console.WriteLine ($"seu IMC é {IMC} você está: Obesidade grau I");
            } else if (IMC > 35 && IMC < 40) {
                System.Console.WriteLine ($"seu IMC é {IMC} você está: Obesidade grau II");
            } else if (IMC >= 40) {
                System.Console.WriteLine ($"seu IMC é {IMC} você está: Obesidade grau III");
            }
        }

        private void SalvarErros (Exception ex) {
            // Usando biblioteca nova StreamWrite serve para escrever/editar arquivos de texto
            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex + "\n");

            txt.Close ();
        }

    }
}