using Questao04.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questao04
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var opcao = 1;
            var contador = 1;
            List<Aluno> alunos = new List<Aluno>();

            while (opcao != 0)
            {
                Console.WriteLine($"Digite a nota do {contador}º aluno ou dígite PARAR para exibir os resultados:");
                var digito = Console.ReadLine();
                if (!digito.Equals("PARAR", StringComparison.OrdinalIgnoreCase))
                {
                    if (decimal.TryParse(digito, out decimal valor))
                    {
                        alunos.Add(new Aluno($"Aluno {contador}º", valor));
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Por favor digite um valor valído para nota.");
                    }
                }
                else
                {
                    opcao = 0;
                }
            }

            if (alunos.Count > 0)
            {
                foreach (var aluno in alunos)
                {
                    if (aluno.Nota > 7)
                    {
                        Console.WriteLine($"{aluno.Nome} Nota: {aluno.Nota}");
                    }
                }
            }
        }
    }
}