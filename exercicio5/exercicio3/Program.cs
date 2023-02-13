using System;

namespace NamespaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            NamespaceContaCorrente.ContaCorrente conta = new  NamespaceContaCorrente.ContaCorrente
            {
                numeroConta = 123456,
                agencia = 1234,
                saldo = 1000,
                nomeTitular = "John Doe"
            };

            Console.WriteLine("Nome do Titular: " + conta.nomeTitular);
            Console.WriteLine("Saldo antes do depósito: " + conta.saldoTotal());

            conta.deposito(500);

            Console.WriteLine("Saldo após o depósito: " + conta.saldoTotal());

            Console.WriteLine("Saldo antes do saque: " + conta.saldoTotal());

            conta.saque(200);

            Console.WriteLine("Saldo após o saque: " + conta.saldoTotal());

            Console.ReadLine();
        }
    }
}
