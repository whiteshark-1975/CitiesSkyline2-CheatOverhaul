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

[BepInPlugin("WhitesharkCheatOverhaul", "WhitesharkCheatOverhaul", "0.3.23")]
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
    public static IReadOnlyDictionary<string, HealthcareOptions> HealthcareOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PostofficeOptions> PostofficeOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, CemeteryOptions> CemeteryOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, CrematoriumOptions> CrematoriumOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, WindturbineOptions> WindturbineOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, EmergencybatteryOptions> EmergencybatteryOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, GeothermalpowerplantOptions> GeothermalpowerplantOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, SolarpowerstationOptions> SolarpowerstationOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, SignatureResidentialbuildingOptions> SignatureResidentialbuildingOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, SignatureCommercialbuildingOptions> SignatureCommercialbuildingOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PostVanOptions> PostVanOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, SignatureOfficebuildingOptions> SignatureOfficebuildingOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, SignatureMixedbuildingOptions> SignatureMixedbuildingOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, FireStationOptions> FireStationOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, FireHelicopterDepotOptions> FireHelicopterDepotOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, FirewatchTowerOptions> FirewatchTowerOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PoliceStationOptions> PoliceStationOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PrisonOptions> PrisonOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, DiseaseControlCenterOptions> DiseaseControlCenterOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, HeathResearchInstituteOptions> HeathResearchInstituteOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, RadioTelescopeOptions> RadioTelescopeOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, GeologicalResearchCenterOptions> GeologicalResearchCenterOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, TechnicalUniversityOptions> TechnicalUniversityOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, EarlyDisasterWarningSystemOptions> EarlyDisasterWarningSystemOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, WelfareOfficeOptions> WelfareOfficeOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, CityHallOptions> CityHallOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, LargeEmergencyShelterOptions> LargeEmergencyShelterOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, CentralBankOptions> CentralBankOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, MedicalUniversityOptions> MedicalUniversityOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, LargeHadronColliderOptions> LargeHadronColliderOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PublicTransportStopsOptions> PublicTransportStopsOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PublicTransportDepotsOptions> PublicTransportDepotsOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PublicTransportStationsOptions> PublicTransportStationsOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, AirportOptions> AirportOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, SpaceCenterOptions> SpaceCenterOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, PostMailboxOptions> PostMailboxOptions { get; private set; } = null!;
    public static IReadOnlyDictionary<string, RadioMastOptions> RadioMastOptions { get; private set; } = null!;

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

        // update the settings to the latest version, and save to file if they were updated
        if (options.UpdateToLatestVersion() > 0)
        {
            try
            {
                WayzSettingsManager.SaveSettings("WhitesharkCheatOverhaul", "settings", options);
            }
            catch
            {
                Logger.LogWarning("Failed to save updated config to settings file, using in-memory updated config.");
            }
        }


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
        WhitesharkCheatOverhaul.HealthcareOptions = options.GetHealthcareDictionary();
        WhitesharkCheatOverhaul.PostofficeOptions = options.GetPostofficeDictionary();
        WhitesharkCheatOverhaul.CemeteryOptions = options.GetCemeteryDictionary();
        WhitesharkCheatOverhaul.CrematoriumOptions = options.GetCrematoriumDictionary();
        WhitesharkCheatOverhaul.WindturbineOptions = options.GetWindturbineDictionary();
        WhitesharkCheatOverhaul.EmergencybatteryOptions = options.GetEmergencybatteryDictionary();
        WhitesharkCheatOverhaul.GeothermalpowerplantOptions = options.GetGeothermalpowerplantDictionary();
        WhitesharkCheatOverhaul.SolarpowerstationOptions = options.GetSolarpowerstationDictionary();
        WhitesharkCheatOverhaul.SignatureResidentialbuildingOptions = options.GetSignatureResidentialbuildingDictionary();
        WhitesharkCheatOverhaul.SignatureCommercialbuildingOptions = options.GetSignatureCommercialbuildingDictionary();
        WhitesharkCheatOverhaul.PostVanOptions = options.GetPostVanDictionary();
        WhitesharkCheatOverhaul.SignatureOfficebuildingOptions = options.GetSignatureOfficebuildingDictionary();
        WhitesharkCheatOverhaul.SignatureMixedbuildingOptions = options.GetSignatureMixedbuildingDictionary();
        WhitesharkCheatOverhaul.FireStationOptions = options.GetFireStationDictionary();
        WhitesharkCheatOverhaul.FireHelicopterDepotOptions = options.GetFireHelicopterDepotDictionary();
        WhitesharkCheatOverhaul.FirewatchTowerOptions = options.GetFirewatchTowerDictionary();
        WhitesharkCheatOverhaul.PoliceStationOptions = options.GetPoliceStationDictionary();
        WhitesharkCheatOverhaul.PrisonOptions = options.GetPrisonDictionary();
        WhitesharkCheatOverhaul.DiseaseControlCenterOptions = options.GetDiseaseControlCenterDictionary();
        WhitesharkCheatOverhaul.HeathResearchInstituteOptions = options.GetHeathResearchInstituteDictionary();
        WhitesharkCheatOverhaul.RadioTelescopeOptions = options.GetRadioTelescopeDictionary();
        WhitesharkCheatOverhaul.GeologicalResearchCenterOptions = options.GetGeologicalResearchCenterDictionary();
        WhitesharkCheatOverhaul.TechnicalUniversityOptions = options.GetTechnicalUniversityDictionary();
        WhitesharkCheatOverhaul.EarlyDisasterWarningSystemOptions = options.GetEarlyDisasterWarningSystemDictionary();
        WhitesharkCheatOverhaul.WelfareOfficeOptions = options.GetWelfareOfficeDictionary();
        WhitesharkCheatOverhaul.CityHallOptions = options.GetCityHallDictionary();
        WhitesharkCheatOverhaul.LargeEmergencyShelterOptions = options.GetLargeEmergencyShelterDictionary();
        WhitesharkCheatOverhaul.CentralBankOptions = options.GetCentralBankDictionary();
        WhitesharkCheatOverhaul.MedicalUniversityOptions = options.GetMedicalUniversityDictionary();
        WhitesharkCheatOverhaul.LargeHadronColliderOptions = options.GetLargeHadronColliderDictionary();
        WhitesharkCheatOverhaul.PublicTransportStopsOptions = options.GetPublicTransportStopsDictionary();
        WhitesharkCheatOverhaul.PublicTransportDepotsOptions = options.GetPublicTransportDepotsDictionary();
        WhitesharkCheatOverhaul.PublicTransportStationsOptions = options.GetPublicTransportStationsDictionary();
        WhitesharkCheatOverhaul.AirportOptions = options.GetAirportDictionary();
        WhitesharkCheatOverhaul.SpaceCenterOptions = options.GetSpaceCenterDictionary();
        WhitesharkCheatOverhaul.PostMailboxOptions = options.GetPostMailboxDictionary();
        WhitesharkCheatOverhaul.RadioMastOptions = options.GetRadioMastDictionary();

        var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID + "_Cities2Harmony");

        var patchedMethods = harmony.GetPatchedMethods();

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} {MyPluginInfo.PLUGIN_VERSION} is loaded! Patched methods: " + patchedMethods.Count());

        foreach (var patchedMethod in patchedMethods)
        {
            Logger.LogInfo($"Patched method: {patchedMethod.Module.Name}:{patchedMethod.Name}");
        }
    }
}