using api_admision.Infraestructure.Data;
using api_admision.Infraestructure.RepositoryImpl;
using api_calidad.Domain.Repository;
using System.Text.Json;

namespace api_calidad.Infraestructure.RepositoryImpl
{
    public class CalidadRepositoryImpl : BaseRepository, ICalidadRepository
    {
        public CalidadRepositoryImpl(ApplicationDbContext context) : base(context) { }
        public async Task<List<JsonElement>> ListarNotasAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_listarEvaluacionesSemanal",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);

            return lista;
        }

        public async Task<List<JsonElement>> RegistrarNotaAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_registrarevaluacion",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);

            return lista;
        }
        public async Task<List<JsonElement>> ReporteSemanalAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_reporteEvaluacionesSemanal",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);

            return lista;
        }
    }
}
