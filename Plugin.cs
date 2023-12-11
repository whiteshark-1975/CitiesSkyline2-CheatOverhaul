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
    public static IReadOnlyDictionary<string, TransformerstationOptions> TransformerstationOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, ServerfarmOptions> ServerfarmOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, GarbagetruckOptions> GarbagetruckOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, TransportbusOptions> TransportbusOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, ParkinghallOptions> ParkinghallOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, CityparkOptions> CityparkOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, WastewaterOptions> WastewaterOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, IncinerationPlantOptions> IncinerationPlantOptions { get; private set; } = null!;



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

        options.RemoveBadEntires();
        
        WhitesharkCheatOverhaul.SchoolOptions = options.GetSchoolDictionary();
        WhitesharkCheatOverhaul.PowerplantOptions = options.GetPowerplantDictionary();
        WhitesharkCheatOverhaul.WaterpumpOptions = options.GetWaterpumpDictionary();
        WhitesharkCheatOverhaul.TransformerstationOptions = options.GetTransformerstationDictionary();
        WhitesharkCheatOverhaul.ServerfarmOptions = options.GetServerfarmDictionary();
        WhitesharkCheatOverhaul.GarbagetruckOptions = options.GetGarbagetruckDictionary();
        WhitesharkCheatOverhaul.TransportbusOptions = options.GetTransportbusDictionary();
        WhitesharkCheatOverhaul.ParkinghallOptions = options.GetParkinghallDictionary();
        WhitesharkCheatOverhaul.CityparkOptions = options.GetCityparkDictionary();
        WhitesharkCheatOverhaul.WastewaterOptions = options.GetWastewaterDictionary();
        WhitesharkCheatOverhaul.IncinerationPlantOptions = options.GetIncinerationPlantDictionary();

        var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID + "_Cities2Harmony");

        var patchedMethods = harmony.GetPatchedMethods();

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} {MyPluginInfo.PLUGIN_VERSION} is loaded! Patched methods: " + patchedMethods.Count());

        foreach (var patchedMethod in patchedMethods)
        {
            Logger.LogInfo($"Patched method: {patchedMethod.Module.Name}:{patchedMethod.Name}");
        }
    }
}