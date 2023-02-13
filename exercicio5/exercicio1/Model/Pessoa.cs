using System;

namespace NamespacePessoa 
{
     public class Pessoa
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public DateTime DataNascimento { get; set; }

        public double IMC()
        {
            return Peso / (Altura * Altura);
        }
    }
}