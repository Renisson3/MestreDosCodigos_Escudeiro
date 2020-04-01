using NUnit.Framework;
using QuestaoPOO02.Entities;
using System;

namespace ProjetoNUnit
{
    [TestFixture]
    public class TestesQuestaoPOO02
    {
        [Test]
        public void TesteDeIdadeCorreto()
        {
            var pessoa = new Pessoa("Renisson Machado Santos", new DateTime(1991, 06, 17), 175);
            var idade = pessoa.CalcularIdade();
            Assert.That(28, Is.EqualTo(idade));
        }

        [Test]
        public void TesteDeIdadeDeveSerZero()
        {
            var pessoa = new Pessoa("José Americo Gois", DateTime.Now, 160);
            var idade = pessoa.CalcularIdade();
            Assert.That(0, Is.EqualTo(idade));
        }
    }
}