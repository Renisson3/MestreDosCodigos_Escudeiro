using QuestaoPOO02.Entities;
using System;
using System.Text;

namespace QuestaoPOO01
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var pessoa = new Pessoa("Renisson Machado Santos", new DateTime(1991, 06, 17), 175);

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Data de Nascimento: {pessoa.DataNascimento:dd/MM/yyyy}");
            Console.WriteLine($"Altura: {pessoa.Altura}");
            Console.WriteLine($"Idade: {pessoa.CalcularIdade()}");
        }
    }
}