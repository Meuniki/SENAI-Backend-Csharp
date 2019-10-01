using System;
using System.IO;
using ex1.Models;

namespace ex1.Controller {
    public class AlunoControler {
        AlunosModels Aluno = new AlunosModels ();

        /// <summary>
        /// Cadastra um aluno
        /// </summary>
        public void CadastrarAluno () {

            Console.Clear ();

            string veribolsa = "";

            Console.Write ("Nome do Aluno: ");
            Aluno.Nome = Console.ReadLine ();

            Console.Write ("Curso do aluno: ");
            Aluno.Curso = Console.ReadLine ();

            try
            { 
            Console.Write("Idade do Aluno: ");
            Aluno.Idade = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("OPS Ouve um erro! :(");
                SalvarErros(ex);
            }
            Console.Write ("RG do aluno: ");
            Aluno.RG = Console.ReadLine ();

            Console.Write ("Aluno é bolsista?: ");
            veribolsa = Console.ReadLine ();

            veribolsa = veribolsa.Replace ("sim", "true");
            veribolsa = veribolsa.Replace ("yes", "true");
            veribolsa = veribolsa.Replace ("y", "true");
            veribolsa = veribolsa.Replace ("n", "false");
            veribolsa = veribolsa.Replace ("não", "false");
            veribolsa = veribolsa.Replace ("no", "false");

            try {
                if (veribolsa == "true") {
                    Aluno.Bolsista = true;
                } else {
                    Aluno.Bolsista = false;
                }
            } catch (Exception ex) {
                System.Console.WriteLine("Ops ocorreu um erro :(");
                SalvarErros(ex);
            }


        }

        /// <summary>
        /// Mostra informações do aluno
        /// </summary>
        public void ExibirAluno(){

            Console.Clear ();

            System.Console.WriteLine($"Nome: {Aluno.Nome}\nCurso: {Aluno.Curso}\nIdade: {Aluno.Idade}\nRG: {Aluno.RG}\n");
            if(Aluno.Bolsista == true){
                System.Console.WriteLine("Aluno é Bolsista");
            }else{
                
                System.Console.WriteLine("Aluno não é Bolsista");
            }
        }

        private void SalvarErros(Exception ex){
            StreamWriter txt = new StreamWriter("error_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();

            txt.Close();
        }
    }
}