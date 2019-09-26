using System;

namespace aula_6_2_CPF {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine( ValidaCPF(cpf));

        }
        static bool ValidaCPF (string cpfUser) {

            bool resultado     = false;
            int[] v1           = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpfcalcuolo = "";
            int resto          =  0;
            int calculo        =  0;
            string digito_v1   = ""; 
            string digito_v2   = ""; 

            cpfUser         = cpfUser.Replace (" ", "");
            cpfUser         = cpfUser.Replace ("-", "");
            cpfUser         = cpfUser.Replace (".", "");

            cpfcalcuolo        = cpfUser.Substring(0,9);

            for (int i = 0; i <= 8; i++) {
                calculo += int.Parse(cpfUser[i].ToString()) * v1[i];
            }

            resto              = calculo % 11;
            calculo            = 11-resto;

            if(calculo >9){
                digito_v1      = "0";
            }else{
                digito_v1      = calculo.ToString();
            }

            if(digito_v1 == cpfUser[9].ToString()){
                resultado      = true;
            }else{
                resultado      = false;
            }

            int[] v2           = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            resto              = 0;
            cpfcalcuolo        = cpfcalcuolo+calculo.ToString();
            calculo            = 0;

            for (int i = 0; i <= 9; i++) {
                calculo += int.Parse(cpfcalcuolo[i].ToString()) * v2[i];
            }

            resto              = calculo % 11;
            calculo            = 11-resto;

            if(calculo >9){
                digito_v2      = "0";
            }else{
                digito_v2      = calculo.ToString();
            }

            if(digito_v2 == cpfUser[10].ToString()){
                resultado      = true;
            }else{
                resultado      = false;
            }

            // if(digito_v1 == true && digito_v2 == true){
            //     resultado = true;
            // }else{
            //     resultado      = false;
            // }


            return resultado;
        }
    }
}