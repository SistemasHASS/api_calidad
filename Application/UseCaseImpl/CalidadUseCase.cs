using api_calidad.Domain.Repository;
using api_calidad.Domain.UseCase;
using System.Text.Json;

namespace api_calidad.Application.UseCaseImpl
{
    public class CalidadUseCase : ICalidadUseCase
    {
        private readonly ICalidadRepository calidadRepository;
        public CalidadUseCase(ICalidadRepository calidadRepository)
        {
            this.calidadRepository = calidadRepository;
        }
        public async Task<List<JsonElement>> ListarNotasAsync(string json)
        {
            return await this.calidadRepository.ListarNotasAsync(json);
        }

        public async Task<List<JsonElement>> RegistrarNotaAsync(string json)
        {
            return await this.calidadRepository.RegistrarNotaAsync(json);
        }

        public async Task<List<JsonElement>> ReporteSemanalAsync(string json)
        {
            return await this.calidadRepository.ReporteSemanalAsync(json);
        }
        public async Task<List<JsonElement>> ListarEvaluacionesAsync(string json)
        {
            return await this.calidadRepository.ListarEvaluacionesAsync(json);
        }
        public async Task<List<JsonElement>> ReporteDetalladoAsync(string json)
        {
            return await this.calidadRepository.ReporteDetalladoAsync(json);
        }

        public async Task<List<JsonElement>> SincronizarDefectosAsync(string json)
        {
            return await this.calidadRepository.SincronizarDefectosAsync(json);
        }

        public async Task<List<JsonElement>> ReporteDefectosAsync(string json)
        {
            return await this.calidadRepository.ReporteDefectosAsync(json);
        }

        public async Task<List<JsonElement>> ReporteBarrasDefectosAsync(string json)
        {
            return await this.calidadRepository.ReporteBarrasDefectosAsync(json);
        }
    }
}
