using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        private int NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "NumeroConta: " + NumeroConta
                +", Nome: " + Nome
                +", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
