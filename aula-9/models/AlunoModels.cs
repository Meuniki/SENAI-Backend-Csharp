using System;
namespace aula_9.model {
    public class AlunoModels {

        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome { get; set; }

        /// <summary>
        /// Nome do curso
        /// </summary>
        /// <value>string</value>
        public string Curso { get; set; }

        /// <summary>
        /// RA do aluno
        /// </summary>
        /// <value>string</value>
        public string RA { get; set; }

        /// <summary>
        /// idade do aluno
        /// </summary>
        /// <value>int</value>
        public int Idade { get; set; }

        //_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_\|/_//
        /// <summary>
        /// Começar a estudar
        /// </summary>
    
        public void Estudar () {
            Console.WriteLine ("Estou estudando!");
        }

        /// <summary>
        /// Pede café para o professor
        /// </summary>
        public void Estudar () {
            Console.WriteLine ("Pode fazer intervalo aeee!");
            Console.WriteLine ("QUERO CAFÉÉÉÉ!!");
        }

        /// <summary>
        /// Pede ajuda
        /// </summary>
        public void Estudar () {
            Console.WriteLine ("Ô Paulo, chega ae!");
        }
    }
}