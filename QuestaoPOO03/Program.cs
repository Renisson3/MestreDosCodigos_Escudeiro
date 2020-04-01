using QuestaoPOO03.Entities;
using System;
using System.Text;

namespace QuestaoPOO03
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Abrindo Contas...");
            var contaCorrente1 = new ContaCorrente(6000, 15);
            var contaCorrente2 = new ContaCorrente(5510, 10);
            var contaEspecial1 = new ContaEspecial(5000, 10000);
            var contaEspecial2 = new ContaEspecial(3000, 1000);

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Contas Criadas:");
            contaCorrente1.MostrarDados();
            contaCorrente2.MostrarDados();
            contaEspecial1.MostrarDados();
            contaEspecial2.MostrarDados();

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Depositando R$500,00 em Todas as contas...");
            contaCorrente1.Depositar(500);
            contaCorrente2.Depositar(500);
            contaEspecial1.Depositar(500);
            contaEspecial2.Depositar(500);

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Exibindo informações atualizadas:");
            contaCorrente1.MostrarDados();
            contaCorrente2.MostrarDados();
            contaEspecial1.MostrarDados();
            contaEspecial2.MostrarDados();

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Sacando R$1000,00 em Todas as contas...");
            Console.WriteLine($"Saque na conta {contaCorrente1.Numero} foi {(contaCorrente1.Sacar(1000) ? "Autorizado." : "Rejeitado.")}");
            Console.WriteLine($"Saque na conta {contaCorrente2.Numero} foi {(contaCorrente2.Sacar(1000) ? "Autorizado." : "Rejeitado.")}");
            Console.WriteLine($"Saque na conta {contaEspecial1.Numero} foi {(contaEspecial1.Sacar(1000) ? "Autorizado." : "Rejeitado.")}");
            Console.WriteLine($"Saque na conta {contaEspecial2.Numero} foi {(contaEspecial2.Sacar(1000) ? "Autorizado." : "Rejeitado.")}");

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Exibindo informações atualizadas:");
            contaCorrente1.MostrarDados();
            contaCorrente2.MostrarDados();
            contaEspecial1.MostrarDados();
            contaEspecial2.MostrarDados();

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Sacando R$5000,00 em Todas as contas...");
            Console.WriteLine($"Saque na conta {contaCorrente1.Numero} foi {(contaCorrente1.Sacar(5000) ? "Autorizado." : "Rejeitado.")}");
            Console.WriteLine($"Saque na conta {contaCorrente2.Numero} foi {(contaCorrente2.Sacar(5000) ? "Autorizado." : "Rejeitado.")}");
            Console.WriteLine($"Saque na conta {contaEspecial1.Numero} foi {(contaEspecial1.Sacar(5000) ? "Autorizado." : "Rejeitado.")}");
            Console.WriteLine($"Saque na conta {contaEspecial2.Numero} foi {(contaEspecial2.Sacar(5000) ? "Autorizado." : "Rejeitado.")}");

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Exibindo informações atualizadas:");
            contaCorrente1.MostrarDados();
            contaCorrente2.MostrarDados();
            contaEspecial1.MostrarDados();
            contaEspecial2.MostrarDados();
        }
    }
}