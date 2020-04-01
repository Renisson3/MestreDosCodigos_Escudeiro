namespace QuestaoPOO04.Entities
{
    public class ControleRemoto
    {
        public ControleRemoto(Televisao televisao)
        {
            Televisao = televisao;
        }

        public Televisao Televisao { get; set; }

        public void AumentarVolume()
        {
            Televisao.Volume++;
        }

        public void DiminuirVolume()
        {
            Televisao.Volume--;
        }

        public void TrocarCanal(int canal)
        {
            Televisao.Canal = canal;
        }
    }
}