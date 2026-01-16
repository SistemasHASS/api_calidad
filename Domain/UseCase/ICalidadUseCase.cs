using System.Text.Json;

namespace api_calidad.Domain.UseCase
{
    public interface ICalidadUseCase
    {
        Task<List<JsonElement>> ListarNotasAsync(string json);
        Task<List<JsonElement>> RegistrarNotaAsync(string json);
        Task<List<JsonElement>> ReporteSemanalAsync(string json);
        Task<List<JsonElement>> ListarEvaluacionesAsync(string json);
        Task<List<JsonElement>> ReporteDetalladoAsync(string json);
    }
}
