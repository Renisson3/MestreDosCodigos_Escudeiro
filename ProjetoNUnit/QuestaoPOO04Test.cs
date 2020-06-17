using NUnit.Framework;
using QuestaoPOO04.Entities;

namespace ProjetoNUnit
{
    [TestFixture]
    public class TestesQuestaoPOO04
    {
        [Test]
        public void TesteDeCriarControle()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            Assert.IsNotNull(controle);
        }

        [Test]
        public void TesteAumentarVolume()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.AumentarVolume();
            Assert.That(21, Is.EqualTo(controle.Televisao.Volume));
        }

        [Test]
        public void TesteDiminuirVolume()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.DiminuirVolume();
            Assert.That(19, Is.EqualTo(controle.Televisao.Volume));
        }

        [Test]
        public void TesteDiminuirVolumeDuasVezes()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.DiminuirVolume();
            controle.DiminuirVolume();
            Assert.That(18, Is.EqualTo(controle.Televisao.Volume));
        }

        [Test]
        public void TesteAumentarCanal()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.AumentarCanal();
            Assert.That(11, Is.EqualTo(controle.Televisao.Canal));
        }

        [Test]
        public void TesteDiminuirCanal()
        {
            var controle = new ControleRemoto(new Televisao(10, 20));
            controle.DiminuirCanal();
            Assert.That(9, Is.EqualTo(controle.Televisao.Canal));
        }
    }
}