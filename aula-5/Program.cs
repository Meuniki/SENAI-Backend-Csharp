using System;

namespace aula_5 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[5];
            string[] origen = new string[5];
            string[] destino = new string[5];
            DateTime[] data_ida = new DateTime[5];
            DateTime[] data_volta = new DateTime[5];

            string sair = "";

            while (sair != "0") {

                Console.WriteLine ("Bem vindo ao nosso sistem de passagens!");
                Console.WriteLine ("Menu :\n1- Cadastar :\n2- Listar passagens :\n0- Sair");

                sair = Console.ReadLine ();

                switch (sair) {
                    case "1":
                        for (int i = 0; i <= 4; i++) {
                            Console.Write ("Entre com o nome completo: ");
                            nome[i] = Console.ReadLine ();

                            Console.Write ("Digite a UF de origen: ");
                            origen[i] = Console.ReadLine ();

                            Console.Write ("Digite a UF de destino: ");
                            destino[i] = Console.ReadLine ();

                            Console.Write ("Digite a data de IDA: ");
                            data_ida[i] = DateTime.Parse (Console.ReadLine ());

                            Console.Write ("Digite a data de VOLTA: ");
                            data_volta[i] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Dados cadastrados com sucesso! :)");
                        }

                    break;

                    case "2":
                        for (int i = 0; i <= 4; i++) {
                            if (nome[i]       != ""   &&
                                origen[i]     != ""   &&
                                destino[i]    != ""   &&
                                data_ida[i]   != null &&
                                data_volta[i] != null) {
                                Console.WriteLine ();
                                Console.WriteLine ($"Passagem Nº {i+1}");

                                Console.WriteLine (nome[i]+"\n"+origen[i]+"\n"+destino[i]+"\n"+data_ida[i]+"\n"+data_volta[i]+"\n");

                            }
                        }
                    break;

                    case "0":
                    Console.WriteLine("Obrigado por ultilizar nosso sistema! ;)");
                    break;

                    default:
                    Console.WriteLine("Entrada invalida");
                    break;
                }
                


            }
        }
    }
}