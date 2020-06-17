using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao07
{
    public static class Program
    {
        public static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;

                var lista = new List<decimal>();

                while (lista.Count < 4)
                {
                    Console.WriteLine($"Digite o {lista.Count + 1}º Valor: ");
                    lista.Add(Convert.ToInt32(Console.ReadLine()));
                }

                var aux = lista.Where(x => (x % 2) == 0).ToList();

                Console.WriteLine($"A soma dos valores é: {aux.Sum()}");
            }
            catch
            {
                Console.WriteLine("Essa aplicação só aceita números como parametros de entrada. Tente novamente");
            }
        }
    }
}