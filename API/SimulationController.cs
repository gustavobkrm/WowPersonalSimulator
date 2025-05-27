using Microsoft.AspNetCore.Mvc;
using ProjetoWow.Application.DTO;
using ProjetoWow.Application.Interfaces;

namespace ProjetoWow.API
{
    public class SimulationController
    {
        private readonly IRunSimulation _runSimulation;
        public SimulationController(IRunSimulation runSimulation)
        {
            _runSimulation = runSimulation;
        }

        [HttpPost("simulate")]
        public async Task<IActionResult> Simulate([FromBody] SimulationRequest request)
        {
            var result = await _runSimulation.Execute(request);
            return Ok(result);
        }


    }
}
