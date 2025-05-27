using ProjetoWow.Domain.Entities;

namespace ProjetoWow.Application.DTO
{
    public class SimulationRequest
    {
        public string SimcInput { get; set; }
        public Gear ModifiedGear { get; set; }
    }
}
