using System;

namespace NamespaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespacePessoa.Pessoa pessoa = new NamespacePessoa.Pessoa
            {
                nome = "John Doe",
                peso = 70,
                altura = 1.75,
                dataNascimento = new DateTime(1980, 1, 1)
            };

            double imc = pessoa.IMC();

            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("IMC: " + imc);

            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc >= 18.5 && imc <= 24.9)
                Console.WriteLine("Peso normal");
            else if (imc >= 25 && imc <= 29.9)
                Console.WriteLine("Sobrepeso");
            else if (imc >= 30 && imc <= 39.9)
                Console.WriteLine("Obesidade");
            else
                Console.WriteLine("Obesidade mórbida");

            Console.ReadLine();
        }
    }
}