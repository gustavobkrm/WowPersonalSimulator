using ProjetoWow.Domain.Entities;

namespace ProjetoWow.Infraestructure.Helpers
{
    public class SimcHelper
    {
        public static string ReplaceGear(string originalSimcText, Gear newGear)
        {
            var lines = originalSimcText.Split('\n');
            var replacedLines = lines.Select(line =>
            {
                if (line.StartsWith("chest=")) return $"chest=,id={newGear.Chest}";
                if (line.StartsWith("trinket1=")) return $"trinket1=,id={newGear.Trinket1}";
                if (line.StartsWith("head=")) return $"head=,id={newGear.Head}";
                if (line.StartsWith("neck=")) return $"neck=,id={newGear.Neck}";
                if (line.StartsWith("shoulder=")) return $"shoulder=,id={newGear.Shoulder}";
                if (line.StartsWith("back=")) return $"back=,id={newGear.Back}";
                if (line.StartsWith("wrist=")) return $"wrist=,id={newGear.Wrist}";
                if (line.StartsWith("hands=")) return $"hands=,id={newGear.Hands}";
                if (line.StartsWith("waist=")) return $"waist=,id={newGear.Waist}";
                if (line.StartsWith("legs=")) return $"legs=,id={newGear.Legs}";
                if (line.StartsWith("feet=")) return $"feet=,id={newGear.Feet}";
                if (line.StartsWith("finger1=")) return $"finger1=,id={newGear.Finger1}";
                if (line.StartsWith("finger2=")) return $"finger2=,id={newGear.Finger2}";
                if (line.StartsWith("trinket2=")) return $"trinket2=,id={newGear.Trinket2}";
                if (line.StartsWith("main_hand=")) return $"main_hand=,id={newGear.MainHand}";
                if (line.StartsWith("off_hand=")) return $"off_hand=,id={newGear.OffHand}";
                return line;
            });

            return string.Join('\n', replacedLines);
        }
    }
}
