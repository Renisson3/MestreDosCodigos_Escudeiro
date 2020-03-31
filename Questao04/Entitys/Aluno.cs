namespace Questao04.Entitys
{
    public class Aluno
    {
        public Aluno(string nome, decimal nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public string Nome { get; set; }
        public decimal Nota { get; set; }
    }
}