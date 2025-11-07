namespace GestaoChamadosDesktop.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public string Usuario { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
    }
}
