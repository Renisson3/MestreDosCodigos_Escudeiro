using Questao04.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
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

            if (alunos?.Any() == true)
            {
                alunos.Where(x => x.Nota > 7).ToList().ForEach(f => Console.WriteLine($"{f.Nome} Nota: {f.Nota}"));
            }
        }
    }
}