using System;
using aula_12_POO_heranca_Composicao_Polimorfismo.Controllers;
using aula_12_POO_heranca_Composicao_Polimorfismo.Models;

namespace aula_12_POO_heranca_Composicao_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carro = new CarrosController();
            CarroEletricoModel CarroEletrico = new CarroEletricoModel();

            Console.Clear();// Limpa a tela do terminal
            
            carro.ligar();
            carro.Desligar();

            carro.Acelerar();
        }
    }
}
