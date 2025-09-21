using BepInEx;
using HarmonyLib;

namespace Silksong.DisableAchievements;

[BepInAutoPlugin(id: "com.spacemonkeyy.silksong_disableachievements")]
public partial class DisableAchievementsPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        Harmony harmony = new(Id);
        harmony.PatchAll();

        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
    }
}

[HarmonyPatch(typeof(AchievementHandler), nameof(AchievementHandler.AwardAchievementToPlayer))]
public class AchievementHandler_AwardAchievementToPlayer_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

[HarmonyPatch(typeof(AchievementHandler), nameof(AchievementHandler.UpdateAchievementProgress))]
public class AchievementHandler_UpdateAchievementProgress_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

[HarmonyPatch(typeof(MenuStyleUnlock), nameof(MenuStyleUnlock.Unlock))]
public class MenuStyleUnlock_Unlock_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}