using GestaoChamadosAPI.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace GestaoChamadosAPI.Servicos
{
    public class ChamadoService
    {
        private static List<Chamado> chamados = new List<Chamado>();

        public List<Chamado> ListarTodos() => chamados;

        public Chamado ObterPorId(int id) =>
            chamados.FirstOrDefault(c => c.Id == id);

        public void Adicionar(Chamado chamado)
        {
            chamado.Id = (chamados.Count == 0) ? 1 : chamados.Max(c => c.Id) + 1;
            chamados.Add(chamado);
        }

        public void Atualizar(Chamado chamado)
        {
            var existente = ObterPorId(chamado.Id);
            if (existente != null)
            {
                existente.Titulo = chamado.Titulo;
                existente.Descricao = chamado.Descricao;
                existente.Status = chamado.Status;
            }
        }

        public void Remover(int id)
        {
            var chamado = ObterPorId(id);
            if (chamado != null)
                chamados.Remove(chamado);
        }
    }
}

