namespace QuestaoPOO04.Entities
{
    public class Televisao
    {
        public Televisao(int canal, int volume)
        {
            Canal = canal;
            Volume = volume;
        }

        public int Canal { get; set; }
        public int Volume { get; set; }
    }
}