using System;

namespace NamespaceProgram 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a mensagem a ser cifrada:");
            string mensagem = Console.ReadLine();

            Console.WriteLine("Digite o valor constante da cifra de César:");
            int valorConstante = Convert.ToInt32(Console.ReadLine());

            string mensagemCifrada = NamespaceCifraCesar.CifraCesar.Criptografia(mensagem, valorConstante);
            Console.WriteLine("Mensagem cifrada: " + mensagemCifrada);
        }
    }
}

