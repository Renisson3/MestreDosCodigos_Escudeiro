using QuestaoPOO04.Entities;
using System;
using System.Text;

namespace QuestaoPOO04
{
    public static class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Criando Televisão e Controle...");
            var controle = new ControleRemoto(new Televisao(1, 15));
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Televisão ligada no Canal {controle.Televisao.Canal} e no Volume {controle.Televisao.Volume}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Trocando Canal da Televisão para 30");
            controle.TrocarCanal(30);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Televisão ligada no Canal {controle.Televisao.Canal} e no Volume {controle.Televisao.Volume}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Aumentando o Volume da Televisão...");
            controle.AumentarVolume();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Televisão ligada no Canal {controle.Televisao.Canal} e no Volume {controle.Televisao.Volume}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Diminuindo o Volume da Televisão...");
            controle.DiminuirVolume();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Televisão ligada no Canal {controle.Televisao.Canal} e no Volume {controle.Televisao.Volume}");
        }
    }
}