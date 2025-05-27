using System.Globalization;
using System.Text.RegularExpressions;

namespace ProjetoWow.Infraestructure.Helpers
{
    public class SimcParser
    {
        public static double ExtractDps(string simcOutput)
        {
            var match = Regex.Match(simcOutput, @"DPS=(\d+(\.\d+)?)");

            if (!match.Success)
                throw new Exception("DPS não encontrado no output do SimulationCraft.");

            if (double.TryParse(match.Groups[1].Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double dps))
                return dps;

            throw new Exception("Valor de DPS inválido.");
        }
    }
}
