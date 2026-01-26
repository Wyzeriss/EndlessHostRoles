using AmongUs.GameOptions;
using EHR;

namespace EHR.Modules
{
    public static class MapSpeedHelper
    {
        public static void ApplyMapSpeed()
        {
            if (!AmongUsClient.Instance.AmHost) return;

            var gameOptions = GameOptionsManager.Instance.CurrentGameOptions;
            if (gameOptions == null) return;

            float speed = gameOptions.GetFloat(FloatOptionNames.PlayerSpeedMod);

            switch (gameOptions.MapId)
            {
                case 0: // Skeld
                    speed = Options.SpeedForSkeld.GetFloat();
                    break;
                case 1: // Mira HeadQoteres (srry for bad engles)
                    speed = Options.SpeedForMira.GetFloat();
                    break;
                case 2: // Police (idk why we doing pursuits now)
                    speed = Options.SpeedForPolus.GetFloat();
                    break;
                case 3: // Dleks 
                    speed = Options.SpeedForSkeld.GetFloat();
                    break;
                case 4: // Aurship <--- Peak typo
                    speed = Options.SpeedForAirship.GetFloat();
                    break;
                case 5: // Fungus (I mean aren't they the same?)   
                    speed = Options.SpeedForFungle.GetFloat();
                    break;
            }

            gameOptions.SetFloat(FloatOptionNames.PlayerSpeedMod, speed);
        }
    }
}
