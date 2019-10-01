using System;
using exercicios_aula_11_POO.Controllers;

namespace exercicios_aula_9_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoasControllers pessoa1 = new PessoasControllers();

            pessoa1.CadastrarPessoa();      
            pessoa1.ExibirDados();
        }
    }
}
