using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao08
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var opcao = 1;
            var contador = 1;
            List<decimal> lista = new List<decimal>();

            while (opcao != 0)
            {
                Console.WriteLine($"Digite o {contador}º valor ou dígite PARAR para exibir os resultados:");
                var digito = Console.ReadLine();
                if (!digito.Equals("PARAR", StringComparison.OrdinalIgnoreCase))
                {
                    if (decimal.TryParse(digito, out decimal valor))
                    {
                        lista.Add(valor);
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

            if (lista?.Any() == true)
            {
                Console.WriteLine($"Valores em ordem crescente: {string.Join(", ", lista.OrderBy(x => x))}");
                Console.WriteLine($"Valores em ordem decrescente: {string.Join(", ", lista.OrderByDescending(x => x))}");
            }
        }
    }
}