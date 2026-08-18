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
        Task<List<JsonElement>> ListarDefectosAsync(string json);
        Task<List<JsonElement>> SincronizarDefectosAsync(string json);
        Task<List<JsonElement>> SincronizarEvaluacionCampoAsync(string json);
        Task<List<JsonElement>> SincronizarEvaluacionAcopioAsync(string json);
        Task<List<JsonElement>> ReporteCampoCicalAsync(string json);
        Task<List<JsonElement>> ReportePlantaCicalAsync(string json);
        Task<List<JsonElement>> ReporteFactoresCicalAsync(string json);
    }
}
