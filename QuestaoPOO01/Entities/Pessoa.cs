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

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento:dd/MM/yyyy}");
            Console.WriteLine($"Altura: {Altura}");
        }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            return DataNascimento > dataAtual.AddYears(-idade) ? (idade - 1) : idade;
        }
    }
}