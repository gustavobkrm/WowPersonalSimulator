using ProjetoWow.Application.DTO;
using ProjetoWow.Infraestructure.Helpers;
using ProjetoWow.Infraestructure.Services.Interfaces;

namespace ProjetoWow.Application.UseCases
{
    public class RunSimulation
    {
        private readonly ISimulateGearService _simulateGearService;

        public RunSimulation(ISimulateGearService simulateGearService)
        {
            _simulateGearService = simulateGearService;
        }

        public async Task<SimulationOutput> Execute(SimulationRequest request)
        {
            var originalResult = await _simulateGearService.Run(request.SimcInput);

            var modifiedSimc = SimcHelper.ReplaceGear(request.SimcInput, request.ModifiedGear);
            var modifiedResult = await _simulateGearService.Run(modifiedSimc);

            return modifiedResult.Dps > originalResult.Dps
                ? new SimulationOutput { Best = "Modified", Dps = modifiedResult.Dps }
                : new SimulationOutput { Best = "Original", Dps = originalResult.Dps };
        }
    }
}
