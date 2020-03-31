using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao09
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var lista = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                lista.Add(new Random().Next(100));
            }

            Console.WriteLine($"Valores da lista: {string.Join(", ", lista)}");

            Console.WriteLine($"Valores da lista em ordem crescente: {string.Join(", ", lista.Select(x => x).OrderBy(x => x))}");

            Console.WriteLine($"Valores da lista em ordem decrescente: {string.Join(", ", lista.Select(x => x).OrderByDescending(x => x))}");

            Console.WriteLine($"Primeiro valor da lista: {string.Join(", ", lista.First())}");

            Console.WriteLine($"Último valor da lista: {string.Join(", ", lista.Last())}");

            lista.Insert(0, new Random().Next(1000));
            Console.WriteLine($"Primeiro valor da lista atualizado: {string.Join(", ", lista.First())}");

            lista.Insert(lista.Count, new Random().Next(1000));
            Console.WriteLine($"Último valor da lista atualizado: {string.Join(", ", lista.Last())}");

            lista.RemoveAt(0);
            Console.WriteLine($"Primeiro valor da lista após remoção: {string.Join(", ", lista.First())}");

            lista.RemoveAt(lista.Count - 1);
            Console.WriteLine($"Último valor da lista após remoção: {string.Join(", ", lista.Last())}");

            Console.WriteLine($"Números pares: {string.Join(", ", lista.Where(x => (x % 2) == 0))}");

            Console.WriteLine("Informe um número da Lista que deseja resgatar: ");

            int valorInformado = 0;

            var condicao = int.TryParse(Console.ReadLine(), out valorInformado);
            while (!condicao || !lista.Contains(valorInformado))
            {
                if (!condicao)
                {
                    Console.WriteLine("Por favor insira apenas números inteiros.");
                }
                else
                {
                    Console.WriteLine("Esse número não está na lista. Tente novamente. ");
                }
                Console.WriteLine("Informe um número da Lista que deseja resgatar: ");
                condicao = int.TryParse(Console.ReadLine(), out valorInformado);
            }

            Console.WriteLine($"O valor informado e resgatado da lista é {lista.First(x => x == valorInformado)}");

            Console.WriteLine($"Lista convertida em Array: {string.Join(", ", lista.ToArray())}");
        }
    }
}