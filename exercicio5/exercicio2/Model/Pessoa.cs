using System;

namespace NamespacePessoa 
{
     public class Pessoa
    {
        public string nome { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public DateTime dataNascimento { get; set; }

        public double IMC()
        {
            return peso / (altura * altura);
        }
    }
}