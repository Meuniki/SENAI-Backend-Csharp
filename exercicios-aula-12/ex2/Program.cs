using System;
using ex2.Controller;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularControler celular = new CelularControler();

            celular.CadastrarCelular();
            celular.LigarCelular();
            celular.FazerLigacao();
            celular.EnviarMensagem();
            celular.DesligarCelular();
            celular.FazerLigacao();
            celular.EnviarMensagem();
            celular.Mostrarespec();
        }
    }
}
