using System;
using System.Text;

namespace Questao01
{
    public static class Program
    {
        public static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("Digite o Valor A: ");
                var a = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o Valor B: ");
                var b = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("Digite 1 para SOMAR A e B.");
                Console.WriteLine("Digite 2 para SUBTRAIR A e B.");
                Console.WriteLine("Digite 3 para DIVIDIR A e B.");
                Console.WriteLine("Digite 4 para MULTIPLICAR A e B.");
                Console.WriteLine("Digite 5 para saber se A e B são números PARES ou IMPARES.");
                Console.WriteLine("Digite 6 para REDIGITAR os valores de A e B.");
                Console.WriteLine("Digite qualquer outro número para ENCERRAR a aplicação.");

                while (true == true)
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine($"Resultado da Soma de {a} + {b} é: {decimal.Add(a, b)}");
                            Console.WriteLine("Digite uma das opções do menu: ");
                            break;

                        case 2:
                            Console.WriteLine($"Resultado da Subtração de {a} - {b} é: {decimal.Subtract(a, b)}");
                            Console.WriteLine("Digite uma das opções do menu: ");
                            break;

                        case 3:
                            Console.WriteLine($" {(b == 0 ? "O B não pode ser 0 na Divisão." : $"Resultado da Divisão de {a} / {b} é: {decimal.Divide(a, b)}")}");
                            Console.WriteLine("Digite uma das opções do menu: ");
                            break;

                        case 4:
                            Console.WriteLine($"Resultado da Multiplicação de {a} * {b} é: {decimal.Multiply(a, b)}");
                            Console.WriteLine("Digite uma das opções do menu: ");
                            break;

                        case 5:
                            Console.WriteLine($"O Valor {a} é {(a % 2 == 0 ? "par" : "impar")} " +
                                $"e o valor {b} é {(b % 2 == 0 ? "par" : "impar")}");
                            Console.WriteLine("Digite uma das opções do menu: ");
                            break;

                        case 6:
                            Console.WriteLine("Digite o Valor A: ");
                            a = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Digite o Valor B: ");
                            b = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Digite uma das opções do menu: ");
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Essa aplicação só aceita números como parametros de entrada. Tente novamente");
            }
        }
    }
}