using ProjetoWow.Application.DTO;

namespace ProjetoWow.Infraestructure.Services.Interfaces
{
    public interface ISimulateGearService
    {
        public Task<SimulationOutput> Run(string simcContent);

    }
}
