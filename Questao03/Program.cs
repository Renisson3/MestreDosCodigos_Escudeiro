using System;
using System.Text;

namespace Questao03
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var a = 1;

            while (a <= 100)
            {
                if ((a % 3) == 0)
                {
                    Console.WriteLine($"{a} é multiplo de 3.");
                    a++;
                }
                else
                {
                    a++;
                }
            }
        }
    }
}