namespace TAREFA2
{
    public class Mapa
    {
        public string Local { get; set; }
        public string Populacao { get; set; }

        public Mapa(string local, string populacao)
        {
            Local = local;
            Populacao = populacao;
        }

        public Mapa()
        {

        }

        public static implicit operator string(Mapa mapa)
        => $"{mapa.Local},{mapa.Populacao}";

        public static implicit operator Mapa(string line)
        {
            var data = line.Split(";");
            return new Mapa(
                data[0],
                data[1]);

        }
    }
}
