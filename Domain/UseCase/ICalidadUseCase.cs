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
        Task<List<JsonElement>> SincronizarDefectosAsync(string json);
        Task<List<JsonElement>> ReporteDefectosAsync(string json);
        Task<List<JsonElement>> ReporteBarrasDefectosAsync(string json);
    }
}
