namespace QuestaoPOO03.Entities
{
    public abstract class ContaBancaria
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public abstract bool Sacar(double valor);

        public bool Depositar(double valor)
        {
            Saldo += valor;
            return true;
        }
    }
}