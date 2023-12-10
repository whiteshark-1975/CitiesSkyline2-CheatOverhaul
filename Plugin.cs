using BepInEx.Logging;
using BepInEx;
using HarmonyLib;
using System.Reflection;
using System.Linq;
using Game.Prefabs;
using System.Collections.Generic;
using Game.Buildings;
using Unity.Entities.UniversalDelegates;
using Unity.Transforms;
using System.Data.SqlTypes;
using Game.Economy;
using Unity.Mathematics;

#if BEPINEX6
using BepInEx.Unity.Mono;
#endif

namespace WhitesharkCheatOverhaul;


[BepInPlugin("WhitesharkCheatOverhaul", "CheatOverhaul", "0.3.14")]
#pragma warning disable BepInEx002
public class WhitesharkCheatOverhaul : BaseUnityPlugin
#pragma warning restore BepInEx002
{
    public static ManualLogSource GameLogger = null!;

    private void Awake()
    {
        GameLogger = Logger;
        var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID + "_Cities2Harmony");

        var patchedMethods = harmony.GetPatchedMethods();

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} {MyPluginInfo.PLUGIN_VERSION} is loaded! Patched methods: " + patchedMethods.Count());

        foreach (var patchedMethod in patchedMethods)
        {
            Logger.LogInfo($"Patched method: {patchedMethod.Module.Name}:{patchedMethod.Name}");
        }
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class PowerPlants_Consumption_Pollution_Production
{
    private static readonly Dictionary<string, (int, int, int, int, int, int, int)> _ConsumptionAndPollution = new()
    {
        { "GasPowerPlant01", (50,0,0,0,0,0,10000000) },
        { "CoalPowerPlant01", (50,0,0,0,0,0,10000000) },
        { "NuclearPowerPlant01", (50,0,0,0,0,0,10000000) },
        { "SmallCoalPowerPlant01", (50,0,0,0,0,0,10000000) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_ConsumptionAndPollution.TryGetValue(prefab.name, out var pair))
        {
            (var cost, var water, var garbage, var air, var ground, var noise, var production) = pair;

            var ConsumptionComponent = prefab.GetComponent<ServiceConsumption>();
            ConsumptionComponent.m_Upkeep = cost;
            ConsumptionComponent.m_GarbageAccumulation = garbage;
            ConsumptionComponent.m_WaterConsumption = water;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_AirPollution = air;
            PollutionComponent.m_GroundPollution = ground;
            PollutionComponent.m_NoisePollution = noise;

            var ProductionComponent = prefab.GetComponent<PowerPlant>();
            ProductionComponent.m_ElectricityProduction = production;
        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class WaterPump_Consumption_Pollution_Production
{
    private static readonly Dictionary<string, (int, int, int, int, int)> _watercostAndCapacity = new()
    {
        { "WaterPumpingStation01", (50,1000000,0,0,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_watercostAndCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var cost, var capacity, var garbage, var electricity, var noise) = pair;

            var ConsumptionComponent = prefab.GetComponent<ServiceConsumption>();
            ConsumptionComponent.m_Upkeep = cost;
            ConsumptionComponent.m_GarbageAccumulation = garbage;
            ConsumptionComponent.m_ElectricityConsumption = electricity;
            var polutionComponent = prefab.GetComponent<Pollution>();
            polutionComponent.m_NoisePollution = noise;
            var pumpComponent = prefab.GetComponent<Game.Prefabs.WaterPumpingStation>();
            pumpComponent.m_Capacity = capacity;
        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class LowpowerPatch_Costs
{
    private static readonly Dictionary<string, (int, int, int)> _lowpowercostAndCapacity = new()
    {
        { "TransformerStation01", (50,0,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_lowpowercostAndCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var cost, var garbage, var noise) = pair;

            var costComponent = prefab.GetComponent<ServiceConsumption>();
            costComponent.m_Upkeep = cost;
            costComponent.m_GarbageAccumulation = garbage;
            
            var polutionComponent = prefab.GetComponent<Pollution>();
            polutionComponent.m_NoisePollution = noise;
            
        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class ServerPatch_Costs
{
    private static readonly Dictionary<string, (int, int, int, int, int, int, int)> _servercostAndCapacity = new()
    {
        { "ServerFarm01", (50,0,0,0,12500,200000,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_servercostAndCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var cost, var electricity, var water, var garbage, var range, var capacity, var noise) = pair;

            var costComponent = prefab.GetComponent<ServiceConsumption>();
            costComponent.m_Upkeep = cost;
            costComponent.m_ElectricityConsumption = electricity;
            costComponent.m_WaterConsumption = water;
            costComponent.m_GarbageAccumulation = garbage;

            var telecomComponent = prefab.GetComponent<Game.Prefabs.TelecomFacility>();
            telecomComponent.m_Range = range;
            telecomComponent.m_NetworkCapacity = capacity;

            var polutionComponent = prefab.GetComponent<Pollution>();
            polutionComponent.m_NoisePollution = noise;

        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class GarbagePatch_Costs
{
    private static readonly Dictionary<string, (int, int)> _garbagecostAndCapacity = new()
    {
        { "GarbageTruck01", (80000,10000) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_garbagecostAndCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var unload) = pair;

            var costComponent = prefab.GetComponent<GarbageTruck>();
            costComponent.m_GarbageCapacity = capacity;
            costComponent.m_UnloadRate = unload;
            


        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class BusPatch_Costs
{
    private static readonly Dictionary<string, (int, int)> _buscostAndCapacity = new()
    {
        { "Bus01", (1000,10000) },
        { "Bus02", (1000,10000) },
        { "Bus03", (1000,10000) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_buscostAndCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var maintenance) = pair;

            var costComponent = prefab.GetComponent<PublicTransport>();
            costComponent.m_PassengerCapacity = capacity;
            costComponent.m_MaintenanceRange = maintenance;



        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class GaragePatch_Costs
{
    private static readonly Dictionary<string, (int, int)> _parkingcostAndCapacity = new()
    {
        { "ParkingHall01", (1000,1) },
        { "ParkingHall02", (1000,1) }
        
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_parkingcostAndCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var comfort) = pair;

            var costComponent = prefab.GetComponent<Game.Prefabs.ParkingFacility>();
            costComponent.m_GarageMarkerCapacity = capacity;
            costComponent.m_ComfortFactor = comfort;



        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class ParkPatch_Happiness
{
    private static readonly Dictionary<string, (int, int, int, int, int, int, int, int)> _parkCoverageAndAttraction = new()
    {
        { "CityPark01", (100000,50000,0,0,0,20000,50,50) },
        { "CityPark02", (100000,50000,0,0,0,20000,50,50) },
        { "CityPark03", (100000,50000,0,0,0,20000,50,50) },
        { "CityPark04", (100000,50000,0,0,0,20000,50,50) }

    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_parkCoverageAndAttraction.TryGetValue(prefab.name, out var pair))
        {
            (var coverage, var attraction, var electricity, var water, var garbage, var capacity, var magnitude, var efficiency) = pair;

            var consumption = prefab.GetComponent<Game.Prefabs.ServiceConsumption>();
            consumption.m_ElectricityConsumption = electricity;
            consumption.m_GarbageAccumulation = garbage;
            consumption.m_WaterConsumption = water;

            var costComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
            costComponent.m_Range = coverage;
            costComponent.m_Capacity = capacity;
            costComponent.m_Magnitude = magnitude;  

            var AttractionComponent = prefab.GetComponent<Game.Prefabs.Attraction>();
            AttractionComponent.m_Attractiveness = attraction;

            var LeisureComponent = prefab.GetComponent<Game.Prefabs.LeisureProvider>();
            LeisureComponent.m_Efficiency = efficiency;


        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class SewagePatch_Costs
{
    private static readonly Dictionary<string, (int, int, int, int, int, int, int)> _sewagecostAndCapacity = new()
    {
        { "WastewaterTreatmentPlant01", (10000000,1,50,0,0,0,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_sewagecostAndCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var purification, var cost, var garbage, var ground, var air, var noise) = pair;

            var SOComponent = prefab.GetComponent<Game.Prefabs.SewageOutlet>();
            SOComponent.m_Capacity = capacity;
            SOComponent.m_Purification = purification;

            var SCComponent = prefab.GetComponent<Game.Prefabs.ServiceConsumption>();
            SCComponent.m_Upkeep = cost;
            SCComponent.m_GarbageAccumulation = garbage;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_GroundPollution = ground;
            PollutionComponent.m_AirPollution = air;
            PollutionComponent.m_NoisePollution = noise;
        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class CustomFarm
{
    private static readonly Dictionary<string, ResourceInEditor[]> _customitems = new()
    {
        { "IndustrialManufacturingSignature01", new[] {
            ResourceInEditor.Paper,
            ResourceInEditor.Furniture,
            ResourceInEditor.Oil,
            ResourceInEditor.Chemicals,
            ResourceInEditor.Stone,
            ResourceInEditor.Livestock,
            ResourceInEditor.Electronics,
            ResourceInEditor.Pharmaceuticals,
            ResourceInEditor.Petrochemicals
          

        }}
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_customitems.TryGetValue(prefab.name, out var items))
        {
            var manufactorComponent = prefab.GetComponent<Game.Prefabs.BuildingProperties>();
            var allowedManufatured = manufactorComponent.m_AllowedManufactured.ToList();
            allowedManufatured.AddRange(items);
            manufactorComponent.m_AllowedManufactured = allowedManufatured.Distinct().ToArray();
        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class CustomPopHouse
{
    private static readonly Dictionary<string, (float, float)> _wellbeingAndRadius = new()
    {
        { "EU_ResidentialLowSignature01", (10000,50000) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_wellbeingAndRadius.TryGetValue(prefab.name, out var pair))
        {
            (var wellbeing, var radius) = pair;

            var effectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
            var wellbeingEffect = effectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.Wellbeing);
            wellbeingEffect.m_Delta = wellbeing;
            wellbeingEffect.m_Radius = radius;
        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class TrainPatch_Costs
{
    private static readonly Dictionary<string, (int, int)> _trainCapacity = new()
    {
        { "TrainPassengerCar01", (1000,10000) },
        { "TrainPassengerEngine01", (1000,10000) }
        
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_trainCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var maintenance) = pair;

            var costComponent = prefab.GetComponent<PublicTransport>();
            costComponent.m_PassengerCapacity = capacity;
            costComponent.m_MaintenanceRange = maintenance;



        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class SubwayPatch_Costs
{
    private static readonly Dictionary<string, (int, int)> _subwayCapacity = new()
    {
        { "SubwayCar01", (1000,10000) },
        { "SubwayEngine01", (1000,10000) }

    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_subwayCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var maintenance) = pair;

            var costComponent = prefab.GetComponent<PublicTransport>();
            costComponent.m_PassengerCapacity = capacity;
            costComponent.m_MaintenanceRange = maintenance;



        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class TramPatch_Costs
{
    private static readonly Dictionary<string, (int, int)> _tramCapacity = new()
    {
        { "TramCar01", (1000,10000) },
        { "TramEngine01", (1000,10000) }

    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_tramCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var maintenance) = pair;

            var costComponent = prefab.GetComponent<PublicTransport>();
            costComponent.m_PassengerCapacity = capacity;
            costComponent.m_MaintenanceRange = maintenance;



        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class PostOfficePatch
{
    private static readonly Dictionary<string, (int, int, int)> _postofficeCapacity = new()
    {
        { "PostOffice01", (1000000,3000,50) }

    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_postofficeCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var storagecapacity, var boxcapacity, var postvan) = pair;

            var costComponent = prefab.GetComponent<Game.Prefabs.PostFacility>();
            costComponent.m_MailStorageCapacity = storagecapacity;
            costComponent.m_MailBoxCapacity = boxcapacity;
            costComponent.m_PostVanCapacity = postvan;

        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class IncineratorPatch_Costs
{
    private static readonly Dictionary<string, (int, int, int, int,int,int,int)> _incineratorCapacity = new()
    {
        { "IncinerationPlant01", (3000000,100,0,50,0,0,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_incineratorCapacity.TryGetValue(prefab.name, out var pair))
        {
            (var garbagecapacity, var vehiclecapacity, var water, var upkeep, var ground, var air, var noise) = pair;
            
            var ConsumptionComponent = prefab.GetComponent<Game.Prefabs.ServiceConsumption>();
            ConsumptionComponent.m_Upkeep = upkeep;
            ConsumptionComponent.m_WaterConsumption= water;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_GroundPollution = ground;
            PollutionComponent.m_AirPollution = air;
            PollutionComponent.m_NoisePollution = noise;

            var capComponent = prefab.GetComponent<Game.Prefabs.GarbageFacility>();
            capComponent.m_GarbageCapacity = garbagecapacity;
            capComponent.m_VehicleCapacity = vehiclecapacity;
            

        }
        return true;
    }
}

[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class Schoolpollution
{
    private static readonly Dictionary<string, (int, int, int)> _ConsumptionAndPollution = new()
    {
        { "ElementarySchool01", (0,0,0) },
        { "Highschool01", (0,0,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_ConsumptionAndPollution.TryGetValue(prefab.name, out var pair))
        {
            (var air, var ground, var noise) = pair;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_AirPollution = air;
            PollutionComponent.m_GroundPollution = ground;
            PollutionComponent.m_NoisePollution = noise;

        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class Windmill
{
    private static readonly Dictionary<string, (int, int, int)> _wind_production_upkeep_noise = new()
    {
        { "WindTurbine01", (100000,50,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_wind_production_upkeep_noise.TryGetValue(prefab.name, out var pair))
        {
            (var production, var cost, var noise) = pair;

            var windComponent = prefab.GetComponent<WindPowered>();
            windComponent.m_Production = production;

            var polutionComponent = prefab.GetComponent<Pollution>();
            polutionComponent.m_NoisePollution = noise;
            
            var costComponent = prefab.GetComponent<ServiceConsumption>();
            costComponent.m_Upkeep = cost;
        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class Battery
{
    private static readonly Dictionary<string, (int, int, int, int, int)> _capacity_upkeep_water_garbage_noise = new()
    {
        { "EmergencyBatteryStation01", (10000000,50,0,0,0) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_capacity_upkeep_water_garbage_noise.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var cost, var water, var garbage, var noise) = pair;

            var capacityComponent = prefab.GetComponent<Game.Prefabs.Battery>();
            capacityComponent.m_Capacity = capacity;

            var polutionComponent = prefab.GetComponent<Pollution>();
            polutionComponent.m_NoisePollution = noise;

            var costComponent = prefab.GetComponent<ServiceConsumption>();
            costComponent.m_Upkeep = cost;
            costComponent.m_WaterConsumption = water;
            costComponent.m_GarbageAccumulation = garbage;


        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class Geothermal
{
    private static readonly Dictionary<string, (int, int, int, int, int, int, int)> _ConsumptionAndPollution = new()
    {
        { "GeothermalPowerPlant01", (50,400,0,0,0,0,10000000) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_ConsumptionAndPollution.TryGetValue(prefab.name, out var pair))
        {
            (var cost, var groundwater, var garbage, var air, var ground, var noise, var production) = pair;

            var ConsumptionComponent = prefab.GetComponent<ServiceConsumption>();
            ConsumptionComponent.m_Upkeep = cost;
            ConsumptionComponent.m_GarbageAccumulation = garbage;
            

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_AirPollution = air;
            PollutionComponent.m_GroundPollution = ground;
            PollutionComponent.m_NoisePollution = noise;

            var ProductionComponent = prefab.GetComponent<GroundWaterPowered>();
            ProductionComponent.m_Production = production;
            ProductionComponent.m_MaximumGroundWater = groundwater;
        }
        return true;
    }
}
[HarmonyPatch(typeof(Game.Prefabs.PrefabSystem), "AddPrefab")]
public static class Solarpowerstation
{
    private static readonly Dictionary<string, (int,int, int, int, int, int, int, int)> _ConsumptionAndPollution = new()
    {
        { "SolarPowerStation01", (1000000,0,50,0,0,0,0,10000000) }
    };

    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (_ConsumptionAndPollution.TryGetValue(prefab.name, out var pair))
        {
            (var capacity, var water, var cost, var garbage, var air, var ground, var noise, var production) = pair;

            var ConsumptionComponent = prefab.GetComponent<ServiceConsumption>();
            ConsumptionComponent.m_Upkeep = cost;
            ConsumptionComponent.m_GarbageAccumulation = garbage;
            ConsumptionComponent.m_WaterConsumption = water;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_AirPollution = air;
            PollutionComponent.m_GroundPollution = ground;
            PollutionComponent.m_NoisePollution = noise;

            var ProductionComponent = prefab.GetComponent<SolarPowered>();
            ProductionComponent.m_Production = production;
            
            var capacityComponent = prefab.GetComponent<Game.Prefabs.Battery>();
            capacityComponent.m_Capacity = capacity;

        }
        return true;
    }
}