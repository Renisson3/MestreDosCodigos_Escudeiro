using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestaoPOO03.Entities;

namespace ProjetoMSTest
{
    [TestClass]
    public class QuestaoPOO03
    {
        [TestMethod]
        public void TesteDeCriarContaCorrente()
        {
            var contaCorrente = new ContaCorrente(6000, 15);
            Assert.IsNotNull(contaCorrente);
        }

        [TestMethod]
        public void TesteDeCriarContaEspecial()
        {
            var contaEspecial = new ContaEspecial(5000, 10000);
            Assert.IsNotNull(contaEspecial);
        }

        [TestMethod]
        public void TesteDeDepositarContaEspecial()
        {
            var contaEspecial = new ContaEspecial(5000, 10000);
            contaEspecial.Depositar(500);
            Assert.AreEqual(5500, contaEspecial.Saldo);
        }

        [TestMethod]
        public void TesteDeDepositarContaCorrente()
        {
            var contaCorrente = new ContaCorrente(5000, 15);
            contaCorrente.Depositar(1000);
            Assert.AreEqual(6000, contaCorrente.Saldo);
        }

        [TestMethod]
        public void TesteDeSacarContaEspecialSaldoDisponivel()
        {
            var contaEspecial = new ContaEspecial(5000, 10000);
            Assert.IsTrue(contaEspecial.Sacar(1000));
        }

        [TestMethod]
        public void TesteDeSacarContaCorrenteSaldoDisponivel()
        {
            var contaCorrente = new ContaCorrente(5000, 15);
            Assert.IsTrue(contaCorrente.Sacar(1000));
        }

        [TestMethod]
        public void TesteDeSacarContaEspecialSaldoIndisponivelELimiteDisponivel()
        {
            var contaEspecial = new ContaEspecial(5000, 10000);
            Assert.IsTrue(contaEspecial.Sacar(6000));
        }

        [TestMethod]
        public void TesteDeSacarContaCorrenteSaldoIndisponivel()
        {
            var contaCorrente = new ContaCorrente(5000, 15);
            Assert.IsFalse(contaCorrente.Sacar(5000));
        }

        [TestMethod]
        public void TesteDeSacarContaEspecialSaldoIndisponivelSemLimite()
        {
            var contaEspecial = new ContaEspecial(5000, 500);
            Assert.IsFalse(contaEspecial.Sacar(6000));
        }

        [TestMethod]
        public void TesteDeSacarContaCorrenteSaldoIndisponivelPelaTaxa()
        {
            var contaCorrente = new ContaCorrente(5000, 15);
            Assert.IsFalse(contaCorrente.Sacar(4990));
        }
    }
}