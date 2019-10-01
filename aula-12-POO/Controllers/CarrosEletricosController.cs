using aula_12_POO_heranca_Composicao_Polimorfismo.Models;

namespace aula_12_POO_heranca_Composicao_Polimorfismo.Controllers {
    public class CarrosEletricosController : CarrosController {
        // Declarando objeto CarroEletricoModel
        CarroEletricoModel CarroEletrico = new CarroEletricoModel ();

        MotorModel motor = new MotorModel ();

        public void CarregarBateria (float carga) {
            if(CarroEletrico.Bateria >100){
                CarroEletrico.Bateria += carga;
            }else{
                System.Console.WriteLine(" A bateria do carro já está completa! Pode viajar!");
            }

        }
        public float StatusBateria(){
           return CarroEletrico.Bateria;
        }
    }
}