using System;

namespace NamespaceContaCorrente
{
    public class ContaCorrente
    {
        public int numeroConta { get; set; }
        public int agencia { get; set; }
        public double saldo { get; set; }
        public string nomeTitular { get; set; }

        public void deposito(double valor)
        {
            saldo += valor;
        }

        public void saque(double valor)
        {
            saldo -= valor;
        }

        public double saldoTotal()
        {
            return saldo;
        }
    }
}
