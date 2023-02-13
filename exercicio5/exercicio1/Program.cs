using System;

namespace NamespaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespacePessoa.Pessoa pessoa = new NamespacePessoa.Pessoa
            {
                Nome = "John Doe",
                Peso = 70,
                Altura = 1.75,
                DataNascimento = new DateTime(1980, 1, 1)
            };

            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("IMC: " + pessoa.IMC());
            Console.ReadLine();
        }
    }
}
