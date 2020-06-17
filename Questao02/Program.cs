using Questao02.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao02
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var opcao = 1;
            var funcionarios = new List<Funcionario>();

            while (opcao != 0)
            {
                var funcionario = new Funcionario();

                Console.WriteLine($"Digite o nome do funcionário ou dígite PARAR para exibir os resultados:");
                funcionario.Nome = Console.ReadLine();

                if (funcionario.Nome.Equals("PARAR", StringComparison.OrdinalIgnoreCase))
                {
                    opcao = 0;
                    break;
                }

                Console.WriteLine($"Digite o valor do salário do {funcionario.Nome} funcionário ou dígite PARAR para exibir os resultados:");
                var digito = Console.ReadLine();

                if (!digito.Equals("PARAR", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (decimal.TryParse(digito, out decimal valor))
                    {
                        funcionario.Salario = valor;
                        funcionarios.Add(funcionario);
                    }
                    else
                    {
                        Console.WriteLine("Por favor digite um valor valído paro salário.");
                    }
                }
                else
                {
                    opcao = 0;
                }
            }

            if (funcionarios.Count > 0)
            {
                var maioresSalarios = funcionarios.OrderByDescending(x => x.Salario).First();
                var menoresSalarios = funcionarios.OrderBy(x => x.Salario).First();
                Console.WriteLine($"O(s) maior(es) salário(s) é(são):" +
                    $" Funcionário(s){maioresSalarios.Nome}," +
                    $" Salário R$:{maioresSalarios.Salario}");
                Console.WriteLine($"O(s) menor(es) salário(s) é(são):" +
                    $" Funcionário(s){menoresSalarios.Nome}," +
                    $" Salário R$:{menoresSalarios.Salario}");
            }
        }
    }
}