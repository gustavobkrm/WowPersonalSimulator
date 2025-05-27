using ProjetoWow.Application.DTO;
using ProjetoWow.Infraestructure.Helpers;
using System.Diagnostics;

namespace ProjetoWow.Infraestructure.Services
{
    public class SimulateGearService
    {
        public async Task<SimulationOutput> Run(string simcContent)
        {
            var filePath = Path.GetTempFileName();
            await File.WriteAllTextAsync(filePath, simcContent);

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "simc.exe",
                    Arguments = filePath,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string output = await process.StandardOutput.ReadToEndAsync();
            process.WaitForExit();

            double dps = SimcParser.ExtractDps(output);

            return new SimulationOutput { Dps = dps };
        }
    }
}
