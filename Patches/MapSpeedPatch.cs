using HarmonyLib;
using EHR.Modules;

namespace EHR.Patches
{
    // Apply speed when the map loads
    [HarmonyPatch(typeof(ShipStatus), nameof(ShipStatus.Start))] 
    public static class MapSpeedPatch
    {
        public static void Postfix()
        {
            MapSpeedHelper.ApplyMapSpeed();
        }
    }

    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Close))] // Speed resets when closing menu fixed
    public static class ReapplyMapSpeedPatch
    {
        public static void Postfix()
        {
            MapSpeedHelper.ApplyMapSpeed();
        }
    }

    [HarmonyPatch(typeof(PlayerPhysics), nameof(PlayerPhysics.FixedUpdate))]
    public static class EnforceMapSpeedPatch // Taken from tou mira
    {
        public static void Prefix(PlayerPhysics __instance)
        {
            if (!AmongUsClient.Instance.AmHost) return;
        
            if (__instance.myPlayer == null) return;
            if (!__instance.myPlayer.AmOwner) return;

            MapSpeedHelper.ApplyMapSpeed();
        }
    }
}
