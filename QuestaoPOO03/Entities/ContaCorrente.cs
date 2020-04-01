using QuestaoPOO03.IEntities;
using System;
using System.Globalization;

namespace QuestaoPOO03.Entities
{
    public class ContaCorrente : ContaBancaria, IContaBancaria
    {
        public ContaCorrente(double saldo, double taxaDeOperacao)
        {
            Numero = new Random().Next(9999999);
            Saldo = saldo;
            TaxaDeOperacao = taxaDeOperacao;
        }

        public double TaxaDeOperacao { get; set; }

        public override bool Sacar(double valor)
        {
            if ((valor + TaxaDeOperacao) <= Saldo)
            {
                Saldo -= (valor + TaxaDeOperacao);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MostrarDados()
        {
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            Console.WriteLine($"Conta Corrente Número:{Numero} tem Saldo: {Saldo.ToString("C", culture)} " +
                $"e Taxa: {TaxaDeOperacao.ToString("C", culture)}");
        }
    }
}