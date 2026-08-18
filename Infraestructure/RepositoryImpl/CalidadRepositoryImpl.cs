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
        public async Task<List<JsonElement>> ListarEvaluacionesAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_recuperarEvaluaciones",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);

            return lista;
        }
        public async Task<List<JsonElement>> ReporteDetalladoAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_reporteEvaluacionesSemanal_detallado",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);
            return lista;
        }
        public async Task<List<JsonElement>> ListarDefectosAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_listardefectos",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);
            return lista;
        }
        public async Task<List<JsonElement>> SincronizarDefectosAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_sincronizardefectos",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);
            return lista;
        }
        public async Task<List<JsonElement>> SincronizarEvaluacionCampoAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_sincronizarevaluacioncampo",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);
            return lista;
        }
        public async Task<List<JsonElement>> SincronizarEvaluacionAcopioAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_sincronizarevaluacionacopio",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);
            return lista;
        }

        public async Task<List<JsonElement>> ReporteCampoCicalAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_reporte_campo",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);
            return lista;
        }

        public async Task<List<JsonElement>> ReportePlantaCicalAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_reporte_planta",
                json,
                result =>
                {
                    var jsonString = result.GetString(0);
                    return JsonSerializer.Deserialize<JsonElement>(jsonString);
                },
                parametrosRequeridos: true);
            return lista;
        }

        public async Task<List<JsonElement>> ReporteFactoresCicalAsync(string json)
        {
            var lista = await EjecutarStoredProcedureAsync<JsonElement>(
                "CALIDAD_reporte_factores",
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
