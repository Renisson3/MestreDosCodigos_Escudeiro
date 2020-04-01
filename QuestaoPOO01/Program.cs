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

            pessoa.ImprimirDados();
            Console.WriteLine($"Idade: {pessoa.CalcularIdade()}");
        }
    }
}