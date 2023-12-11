using Game.Modding;
using Game.Prefabs;
using HarmonyLib;
using Unity.Mathematics;

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

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Waterpumpoverrides.UpkeepCost;
            ServiceComponent.m_GarbageAccumulation = Waterpumpoverrides.GarbageAccumulation;
            ServiceComponent.m_ElectricityConsumption = Waterpumpoverrides.ElectricityConsumption;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Waterpumpoverrides.NoisePollution;

            var PumpComponent = prefab.GetComponent<Game.Prefabs.WaterPumpingStation>();
            PumpComponent.m_Capacity = Waterpumpoverrides.Capacity;

        }

        if (WhitesharkCheatOverhaul.TransformerstationOptions.TryGetValue(prefab.name, out var Transformerstationoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Transformerstationoverrides.UpkeepCost;
            ServiceComponent.m_GarbageAccumulation = Transformerstationoverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Transformerstationoverrides.NoisePollution;

        }

        if (WhitesharkCheatOverhaul.ServerfarmOptions.TryGetValue(prefab.name, out var Serverfarmoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Serverfarmoverrides.UpkeepCost;
            ServiceComponent.m_ElectricityConsumption = Serverfarmoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = Serverfarmoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = Serverfarmoverrides.GarbageAccumulation;

            var TelecomComponent = prefab.GetComponent<TelecomFacility>();
            TelecomComponent.m_Range = Serverfarmoverrides.Range;
            TelecomComponent.m_NetworkCapacity = Serverfarmoverrides.Capacity;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Serverfarmoverrides.NoisePollution;

        }

        if (WhitesharkCheatOverhaul.GarbagetruckOptions.TryGetValue(prefab.name, out var Garbagetruckoverrides))
        {

            var GarbageComponent = prefab.GetComponent<GarbageTruck>();
            GarbageComponent.m_GarbageCapacity = Garbagetruckoverrides.Capacity;
            GarbageComponent.m_UnloadRate = Garbagetruckoverrides.Unloadrate;
           
        }

        if (WhitesharkCheatOverhaul.TransportbusOptions.TryGetValue(prefab.name, out var Transportbusoverrides))
        {

            var TransportComponent = prefab.GetComponent<PublicTransport>();
            TransportComponent.m_PassengerCapacity = Transportbusoverrides.Passengercapacity;
            TransportComponent.m_MaintenanceRange = Transportbusoverrides.Maintenancerange;

        }

        if (WhitesharkCheatOverhaul.ParkinghallOptions.TryGetValue(prefab.name, out var Parkinghalloverrides))
        {

            var ParkinghallComponent = prefab.GetComponent<ParkingFacility>();
            ParkinghallComponent.m_GarageMarkerCapacity = Parkinghalloverrides.GarageCapacity;
            ParkinghallComponent.m_ComfortFactor = Parkinghalloverrides.Comfortfactor;

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Parkinghalloverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = Parkinghalloverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = Parkinghalloverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = Parkinghalloverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Parkinghalloverrides.Noisepollution;
        }

        return true;
    }
}