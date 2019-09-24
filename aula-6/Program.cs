﻿using System;

namespace aula_6 {
    class Program {
        static void Main (string[] args) {

            // Chamamos nossa primeira função
            Console.WriteLine (BomDia ());

            // Chamamos a função do tipo void (sem retorno)
            ImprimiDataHora ();

            // Chamamos nossa função que calcula a média
            double[] numeros = {2 , 5 , 2 , 3 , 9 ,8};
            Console.WriteLine(CalculaMedia(numeros));

            // Chamamos a função de soma
            Console.WriteLine(CalculaSoma(numeros));


        }


        /// <summary>
        /// Função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>Retorna Olá! Bom dia!!</returns>
        static string BomDia () {
            return "Olá! Bom dia!!";
        }
        /// <summary>
        /// Função que mostra uma saudação de acordo com o horário atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de método)</param>
        /// <returns>Saudação de acordo com o horário</returns>
        static string BomDia (string saudacao) {

            int hora = DateTime.Now.Hour;

            if (hora <= 11 && hora >= 6) {
                saudacao = "Bom dia";
            } else if (hora >= 12 && hora <= 18) {
                saudacao = "Boa tarde";
            } else {
                saudacao = "Boa noite";
            }

            return saudacao;
        }

        /// <summary>
        /// Retorna um número - Teste de Sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado como parâmetro</returns>
        static int BomDia (int numero) {
            return numero;
        }

        /// <summary>
        /// Retorna data e Hora atual
        /// </summary>
        static void ImprimiDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour.ToString ());
        }

        /// <summary>
        /// Função que calcula a média de um valor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia (double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }
            resultado = resultado / valores.Length;

            return resultado;
        }
        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="valores">Vetor de um vetor</param>
        /// <returns></returns>
        static double CalculaSoma (double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }

            return resultado;
        }

        
    }
}