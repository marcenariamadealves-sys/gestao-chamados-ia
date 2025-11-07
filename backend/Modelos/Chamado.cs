namespace GestaoChamadosAPI.Modelos
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; } = DateTime.Now;
    }
}
