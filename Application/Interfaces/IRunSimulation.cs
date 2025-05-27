using ProjetoWow.Application.DTO;

namespace ProjetoWow.Application.Interfaces
{
    public interface IRunSimulation
    {
        public Task<string> Execute(SimulationRequest request);

    }
}
