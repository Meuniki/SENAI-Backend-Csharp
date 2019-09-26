using System;

namespace exercicio_aula_6 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite o CNPJ: ");
            string cnpj = Console.ReadLine ();

            Console.WriteLine (ValidarCNPJ (cnpj));
        }

        static bool ValidarCNPJ (string cnpj_user) {

            bool resultado = false;
            int[] v1 = { 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string cnpjcalcuolo = "";
            string cnpjcalcuolo2 = "";
            int resto = 0;
            int calculo = 0;
            string veri1;
            string veri2 = cnpj_user[12].ToString () + cnpj_user[13].ToString ();
            string digito_v1 = "";
            string digito_v2 = "";

            cnpj_user = cnpj_user.Replace (" ", "");
            cnpj_user = cnpj_user.Replace ("-", "");
            cnpj_user = cnpj_user.Replace (".", "");
            cnpj_user = cnpj_user.Replace ("/", "");

            cnpjcalcuolo2 = cnpj_user.Substring (0, 12);

            for (int i = 0; i <= 11; i++) {
                calculo += int.Parse (cnpj_user[i].ToString ()) * v1[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo < 2) {
                digito_v1 = "0";
            } else {
                digito_v1 = calculo.ToString ();
            }

            int[] v2 = { 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            cnpjcalcuolo2 = cnpj_user.Substring (0, 12) + digito_v1;
            resto = 0;

            cnpjcalcuolo2 = cnpjcalcuolo2 + calculo.ToString ();
            calculo = 0;

            for (int i = 0; i <= 12; i++) {
                calculo += int.Parse (cnpjcalcuolo2[i].ToString ()) * v2[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo < 2) {
                digito_v2 = "0";
            } else {
                digito_v2 = calculo.ToString ();
            }

            veri1 = digito_v1 + digito_v2;

            if (veri1 == veri2) {
                resultado = true;
            }else{
                resultado = false;
            }

            return resultado;
        }
    }
}