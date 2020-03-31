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
            var contador = 1;
            Dictionary<int, decimal> funcionarios = new Dictionary<int, decimal>();

            while (opcao != 0)
            {
                Console.WriteLine($"Digite o valor do salário do {contador}º funcionário ou dígite PARAR para exibir os resultados:");
                var digito = Console.ReadLine();
                if (!digito.Equals("PARAR", StringComparison.OrdinalIgnoreCase))
                {
                    if (decimal.TryParse(digito, out decimal valor))
                    {
                        funcionarios.Add(contador, valor);
                        contador++;
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

            if (funcionarios != null && funcionarios.Any())
            {
                var maioresSalarios = funcionarios.Where(x => x.Value == funcionarios.Values.Max()).ToList();
                var menoresSalarios = funcionarios.Where(x => x.Value == funcionarios.Values.Min()).ToList();
                Console.WriteLine($"O(s) maior(es) salário(s) é(são):" +
                    $" Funcionário(s){string.Join("º, ", maioresSalarios.Select(f => f.Key))}º" +
                    $" Salário R$:{maioresSalarios.First().Value}");
                Console.WriteLine($"O(s) menor(es) salário(s) é(são):" +
                    $" Funcionário(s){string.Join("º, ", menoresSalarios.Select(f => f.Key))}º" +
                    $" Salário R$:{menoresSalarios.First().Value}");
            }
        }
    }
}