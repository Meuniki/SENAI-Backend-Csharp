using System;
using ex2.Models;

namespace ex2.Controller
{
    public class CelularControler
    {
        CelularModel celular = new CelularModel();

        public void CadastrarCelular(){
            System.Console.Write("Cor do celular: ");
            celular.Cor = Console.ReadLine();
            
            System.Console.Write("Modelo do celular: ");
            celular.Modelo = Console.ReadLine();
            
            System.Console.Write("Tamanho do celular: ");
            celular.Tamanho = double.Parse(Console.ReadLine());
        }

        public void LigarCelular(){
            celular.Ligado = true;
            Console.WriteLine("Celular está ligado");
        }

        public void DesligarCelular(){
            celular.Ligado = false;
            System.Console.WriteLine("Celular está desligado");
        }
        public void FazerLigacao(){
            if(celular.Ligado == true){
                System.Console.WriteLine("ALO??? é da vivo...");
            }else{
                System.Console.WriteLine("O Celular está desligado...");
            }
        }

        public void EnviarMensagem(){
            if(celular.Ligado == true){
                System.Console.WriteLine("Enviando mensagem");
            }else{
                System.Console.WriteLine("O Celular está desligado...");
            }
        }
        public void Mostrarespec(){
            System.Console.WriteLine($"Cor: {celular.Cor}\nModelo: {celular.Modelo}\nTamanho: {celular.Tamanho}");
        }
    }
}