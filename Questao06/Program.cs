using System;

namespace Questao06
{
    public static class Program
    {
        public static void Main()
        {
            var valor = 1000;
            Console.WriteLine($"Valor Inicial: {valor}");

            AtribuirValorPorRef(ref valor);
            Console.WriteLine($"Valor REF: {valor}");

            AtribuirValorPorOut(out valor);
            Console.WriteLine($"Valor OUT: {valor}");
            Console.ReadLine();
        }

        public static void AtribuirValorPorOut(out int valor)
        {
            valor = 50;
        }

        public static void AtribuirValorPorRef(ref int valor)
        {
            valor = valor * 2;
        }
    }
}