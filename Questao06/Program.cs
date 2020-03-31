using System;

namespace Questao06
{
    public static class Program
    {
        public static void Main()
        {
            var valor = 6;

            AtribuirValorPorOut(out valor);
            Console.WriteLine($"Valor OUT: {valor}");

            valor = 6;

            AtribuirValorPorRef(ref valor);
            Console.WriteLine($"Valor REF: {valor}");
            Console.ReadLine();
        }

        public static void AtribuirValorPorOut(out int valor)
        {
            valor = 44;
        }

        public static void AtribuirValorPorRef(ref int valor)
        {
            valor += 44;
        }
    }
}