using System;

namespace QuestaoPOO02.Entities
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento, decimal altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public decimal Altura { get; private set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            return dataAtual.DayOfYear < DataNascimento.DayOfYear ? (idade - 1) : idade;
        }
    }
}