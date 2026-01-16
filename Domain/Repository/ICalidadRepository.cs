using System.Text.Json;

namespace api_calidad.Domain.Repository
{
    public interface ICalidadRepository
    {
        Task<List<JsonElement>> ListarNotasAsync(string json);
        Task<List<JsonElement>> RegistrarNotaAsync(string json);
        Task<List<JsonElement>> ReporteSemanalAsync(string json);
        Task<List<JsonElement>> ListarEvaluacionesAsync(string json);
        Task<List<JsonElement>> ReporteDetalladoAsync(string json);
    }
}
