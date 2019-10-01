using System;
using aula_12_POO_heranca_Composicao_Polimorfismo.Models;

namespace aula_12_POO_heranca_Composicao_Polimorfismo.Controllers
{
    public class CarrosController
    {
        CarroModel carro = new CarroModel();
        MotorModel motor = new MotorModel();

        public void ligar(){

            carro.Ligado = true;
            System.Console.WriteLine("Ligando carro!");
        }
        public void Desligar(){
            carro.Ligado = false;
            System.Console.WriteLine("Desligando carro...");

        }
        public void Acelerar(){

            if(carro.Ligado == true){
                System.Console.WriteLine("Carro acelerando");
            }else{
                System.Console.WriteLine("O carro não está ligado! Imposspível acelerar!");
            }

        }
        public void Frear(){
            if(carro.Ligado == true){
                System.Console.Write("Carro freando...");
            }else{
                System.Console.Write("O carro não está ligado! Imposspível frear!");
            }
        }

        public void CadastrarMotor(){
            System.Console.Write("Insira quandos cavalos tem o mator:");
            motor.Cavalos = int.Parse(Console.ReadLine());

            System.Console.Write("Insira quandos cilindros tem o mator:");
            motor.Cilindros = int.Parse(Console.ReadLine());

            System.Console.Write("Insira o modelo do pistão do carro:");
            motor.Pistao = Console.ReadLine();
            
        }
    }
}