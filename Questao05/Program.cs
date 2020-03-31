using System;
using System.Text;

namespace Questao05
{
    public static class Program
    {
        private static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("Digite o Valor A: ");
                var a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor B: ");
                var b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o Valor C: ");
                var c = Convert.ToDouble(Console.ReadLine());

                var delta = ((b * b) - (4 * a * c));

                if (delta >= 0)
                {
                    Console.WriteLine("O X1:" + ((-b + Math.Sqrt(delta)) / (2 * a)));
                    Console.WriteLine("O X2: " + ((-b - Math.Sqrt(delta)) / (2 * a)));
                }
                else
                {
                    Console.WriteLine("Delta < 0");
                }
            }
            catch
            {
                Console.WriteLine("Essa aplicação só aceita números como parametros de entrada. Tente novamente");
            }
        }
    }
}