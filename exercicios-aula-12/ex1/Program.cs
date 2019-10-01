using System;
using ex1.Controller;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoControler Aluno = new AlunoControler();
            
            Aluno.CadastrarAluno();
            Aluno.ExibirAluno();
            
        }
    }
}
