using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestaoPOO04.Entities;

namespace ProjetoMSTest
{
    [TestClass]
    public class QuestaoPOO04
    {
        [TestMethod]
        public void TesteDeCriarControle()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            Assert.IsNotNull(controle);
        }

        [TestMethod]
        public void TesteAumentarVolume()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.AumentarVolume();
            Assert.AreEqual(21, controle.Televisao.Volume);
        }

        [TestMethod]
        public void TesteDiminuirVolume()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.DiminuirVolume();
            Assert.AreEqual(19, controle.Televisao.Volume);
        }

        [TestMethod]
        public void TesteDiminuirVolumeDuasVezes()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.DiminuirVolume();
            controle.DiminuirVolume();
            Assert.AreEqual(18, controle.Televisao.Volume);
        }

        [TestMethod]
        public void TesteTrocarCanal()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.TrocarCanal(20);
            Assert.AreEqual(20, controle.Televisao.Canal);
        }
    }
}