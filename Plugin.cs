#if BEPINEX6
using BepInEx.Unity.Mono;
#endif
using BepInEx.Logging;
using BepInEx;
using HarmonyLib;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Wayz.CS2;

namespace WhitesharkCheatOverhaul;

[BepInPlugin("WhitesharkCheatOverhaul", "WhitesharkCheatOverhaul", "0.4.0")]
public class WhitesharkCheatOverhaul : BaseUnityPlugin
{
    public static ManualLogSource GameLogger = null!;

    public static IReadOnlyDictionary<string, SchoolOptions> SchoolOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PowerplantOptions> PowerplantOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, WaterpumpOptions> WaterpumpOptions { get; private set; } = null!;

    private void Awake()
    {
        GameLogger = Logger;

        WhitesharkCheatOverhaulOptions options;
        if (!WayzSettingsManager.TryGetSettings<WhitesharkCheatOverhaulOptions>("WhitesharkCheatOverhaul", "settings", out options))
        {
            options = WhitesharkCheatOverhaulOptions.Default;
            try
            {
                WayzSettingsManager.SaveSettings("WhitesharkCheatOverhaul", "settings", options);
            }
            catch
            {
                Logger.LogWarning("Failed to save default config to settings file, using in-memory default config.");
            }
        }

        var filtered = options.RemoveBadEntires();
        if(filtered != 0)
        {
            Logger.LogWarning($"Removed {filtered} bad entries loaded from settings file!");
        }
        WhitesharkCheatOverhaul.SchoolOptions = options.GetSchoolDictionary();
        WhitesharkCheatOverhaul.PowerplantOptions = options.GetPowerplantDictionary();
        WhitesharkCheatOverhaul.WaterpumpOptions = options.GetWaterpumpDictionary();


        var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID + "_Cities2Harmony");

        var patchedMethods = harmony.GetPatchedMethods();

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} {MyPluginInfo.PLUGIN_VERSION} is loaded! Patched methods: " + patchedMethods.Count());

        foreach (var patchedMethod in patchedMethods)
        {
            Logger.LogInfo($"Patched method: {patchedMethod.Module.Name}:{patchedMethod.Name}");
        }
    }
}