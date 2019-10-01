namespace aula_12_POO_heranca_Composicao_Polimorfismo.Models
{
    public class CarroModel
    {
        public string Marca {get; set;}

        public string Modelo {get; set;}

        public string Cor {get; set;}
        
        public string Placa {get; set;}

        public bool Ligado {get; set;}
        
        public MotorModel Motor{get;set;}
    }
}