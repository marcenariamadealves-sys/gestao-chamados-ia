using Microsoft.AspNetCore.Mvc;
using GestaoChamadosAPI.Modelos;
using GestaoChamadosAPI.Servicos;
using System.Collections.Generic;

namespace GestaoChamadosAPI.Controladores
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChamadosController : ControllerBase
    {
        private readonly ChamadoService _service = new ChamadoService();

        [HttpGet]
        public ActionResult<List<Chamado>> GetTodos()
        {
            return Ok(_service.ListarTodos());
        }

        [HttpGet("{id}")]
        public ActionResult<Chamado> GetPorId(int id)
        {
            var chamado = _service.ObterPorId(id);
            if (chamado == null) return NotFound();
            return Ok(chamado);
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] Chamado chamado)
        {
            _service.Adicionar(chamado);
            return CreatedAtAction(nameof(GetPorId), new { id = chamado.Id }, chamado);
        }

        [HttpPut("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Chamado chamado)
        {
            chamado.Id = id;
            _service.Atualizar(chamado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Remover(int id)
        {
            _service.Remover(id);
            return NoContent();
        }
    }
}
