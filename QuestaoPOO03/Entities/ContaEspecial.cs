using QuestaoPOO03.IEntities;
using System;
using System.Globalization;

namespace QuestaoPOO03.Entities
{
    public class ContaEspecial : ContaBancaria, IContaBancaria
    {
        public ContaEspecial(double saldo, double limite)
        {
            Numero = new Random().Next(9999999);
            Saldo = saldo;
            Limite = limite;
        }

        public double Limite { get; set; }

        public override bool Sacar(double valor)
        {
            if (Math.Abs(valor - Saldo) <= Limite)
            {
                Saldo -= valor;
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
            Console.WriteLine($"Conta Especial Número:{Numero} tem Saldo: {Saldo.ToString("C", culture)}" +
                $" e Limite: {Limite.ToString("C", culture)}");
        }
    }
}