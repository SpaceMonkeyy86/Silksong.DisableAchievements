using BepInEx;
using HarmonyLib;

namespace DisableAchievements;

[BepInAutoPlugin(id: "com.spacemonkeyy.disableachievements")]
public partial class DisableAchievementsPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        Harmony harmony = new(Id);
        harmony.PatchAll();
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

[HarmonyPatch(typeof(GameManager), nameof(GameManager.SetStatusRecordInt))]
public class GameManager_SetStatusRecordInt_Patch
{
    public static bool Prefix(string key)
    {
        if (key.StartsWith("Rec") && key.EndsWith("Mode"))
        {
            return false;
        }

        return true;
    }
}

[HarmonyPatch(typeof(SteelSoulUnlockSequence), nameof(SteelSoulUnlockSequence.ShouldShow), MethodType.Getter)]
public class SteelSoulUnlockSequence_ShouldShow_Patch
{
    public static bool Prefix(ref bool __result)
    {
        __result = false;
        return false;
    }
}