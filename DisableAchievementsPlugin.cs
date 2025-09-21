using BepInEx;

namespace Silksong.DisableAchievements;

// TODO - adjust the plugin guid as needed
[BepInAutoPlugin(id: "io.github.silksong_disableachievements")]
public partial class DisableAchievementsPlugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Put your initialization logic here
        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
    }
}