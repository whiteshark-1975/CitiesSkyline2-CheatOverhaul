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
            
                var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
                ServiceComponent.m_Upkeep = Powerplantoverrides.UpkeepCost;
                ServiceComponent.m_GarbageAccumulation = Powerplantoverrides.GarbageAccumulation;
                ServiceComponent.m_WaterConsumption = Powerplantoverrides.Waterconsumption;
          
            
                var PollutionComponent = prefab.GetComponent<Pollution>();
                PollutionComponent.m_AirPollution = Powerplantoverrides.AirPollution;
                PollutionComponent.m_GroundPollution = Powerplantoverrides.GroundPollution;
                PollutionComponent.m_NoisePollution = Powerplantoverrides.NoisePollution;
           
                var ProductionComponent = prefab.GetComponent<PowerPlant>();
                ProductionComponent.m_ElectricityProduction = Powerplantoverrides.Production;
            
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