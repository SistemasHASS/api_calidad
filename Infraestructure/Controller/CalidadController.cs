using api_calidad.Domain.UseCase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace api_calidad.Infraestructure.Controller
{
    [Route("api/calidad")]
    [ApiController]
    public class CalidadController : ControllerBase
    {
        private readonly ICalidadUseCase calidadUseCase;

        public CalidadController(ICalidadUseCase calidadUseCase)
        {
            this.calidadUseCase = calidadUseCase;
        }

        [HttpPost("listar-notas")]
        [ProducesResponseType(typeof(JsonElement), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<dynamic>> ListarNotas([FromBody] JsonElement? body = null)
        {
            string json = body.HasValue && body.Value.ValueKind != JsonValueKind.Null ? body.Value.ToString() : "[]";
            var resultado = await this.calidadUseCase.ListarNotasAsync(json);
            return Ok(resultado.FirstOrDefault());
        }

        [HttpPost("registrar-nota")]
        [ProducesResponseType(typeof(JsonElement), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<dynamic>> RegistrarNota([FromBody] JsonElement? body = null)
        {
            string json = body.HasValue && body.Value.ValueKind != JsonValueKind.Null ? body.Value.ToString() : "[]";
            var resultado = await this.calidadUseCase.RegistrarNotaAsync(json);
            return Ok(resultado.FirstOrDefault());
        }

        [HttpPost("reporte-semanal")]
        [ProducesResponseType(typeof(JsonElement), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<dynamic>> ReporteSemanal([FromBody] JsonElement? body = null)
        {
            string json = body.HasValue && body.Value.ValueKind != JsonValueKind.Null ? body.Value.ToString() : "[]";
            var resultado = await this.calidadUseCase.ReporteSemanalAsync(json);
            return Ok(resultado.FirstOrDefault());
        }
    }
}
