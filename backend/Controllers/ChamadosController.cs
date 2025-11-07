using Microsoft.AspNetCore.Mvc;

namespace GestaoChamadosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChamadosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListarChamados()
        {
            return Ok(new[] { "Chamado 1", "Chamado 2" });
        }

        [HttpPost]
        public IActionResult CriarChamado([FromBody] object chamado)
        {
            return Ok("Chamado criado com sucesso!");
        }
    }
}

