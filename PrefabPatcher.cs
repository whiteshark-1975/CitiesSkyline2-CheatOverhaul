using Game.Modding;
using Game.Prefabs;
using HarmonyLib;

namespace WhitesharkCheatOverhaul;

[HarmonyPatch(typeof(PrefabSystem), "AddPrefab")]
public static class PrefabPatcher
{
    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (WhitesharkCheatOverhaul.SchoolOptions.TryGetValue(prefab.name, out var Schooloverrides))
        {
            if (Schooloverrides.UpkeepCost != 0)
            {
                var costComponent = prefab.GetComponent<ServiceConsumption>();
                costComponent.m_Upkeep = Schooloverrides.UpkeepCost;
            }

        }

        if (WhitesharkCheatOverhaul.PowerplantOptions.TryGetValue(prefab.name, out var Powerplantoverrides))
        {
            if (Powerplantoverrides.UpkeepCost != 0)
            {
                var UpkeepComponent = prefab.GetComponent<ServiceConsumption>();
                UpkeepComponent.m_Upkeep = Powerplantoverrides.UpkeepCost;
            }
            if (Powerplantoverrides.GarbageAccumulation != 0)
            {
                var GarbageComponent = prefab.GetComponent<ServiceConsumption>();
                GarbageComponent.m_GarbageAccumulation = Powerplantoverrides.GarbageAccumulation;
            }
            if (Powerplantoverrides.Waterconsumption != 0)
            {
                var WaterComponent = prefab.GetComponent<ServiceConsumption>();
                WaterComponent.m_WaterConsumption = Powerplantoverrides.Waterconsumption;
            }
            if (Powerplantoverrides.AirPollution != 0)
            {
                var AirComponent = prefab.GetComponent<Pollution>();
                AirComponent.m_AirPollution = Powerplantoverrides.AirPollution;
            }
            if (Powerplantoverrides.GroundPollution != 0)
            {
                var GroundComponent = prefab.GetComponent<Pollution>();
                GroundComponent.m_GroundPollution = Powerplantoverrides.GroundPollution;
            }
            if (Powerplantoverrides.NoisePollution != 0)
            {
                var NoiseComponent = prefab.GetComponent<Pollution>();
                NoiseComponent.m_NoisePollution = Powerplantoverrides.NoisePollution;
            }
            if (Powerplantoverrides.Production != 0)
            {
                var ProductionComponent = prefab.GetComponent<PowerPlant>();
                ProductionComponent.m_ElectricityProduction = Powerplantoverrides.Production;
            }
        }
      
        if (WhitesharkCheatOverhaul.WaterpumpOptions.TryGetValue(prefab.name, out var Waterpumpoverrides))
        {
            if (Waterpumpoverrides.UpkeepCost != 0)
            {
                var costComponent = prefab.GetComponent<ServiceConsumption>();
                costComponent.m_Upkeep = Waterpumpoverrides.UpkeepCost;
            }

        }
        return true;
    }
}