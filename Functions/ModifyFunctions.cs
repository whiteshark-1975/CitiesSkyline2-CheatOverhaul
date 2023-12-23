using Game.Prefabs;

namespace WhitesharkCheatOverhaul;
public void ModifyServiceConsumption(PrefabBase prefab, IServiceConsumptionOptions options)
{
    var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
    ServiceComponent.m_Upkeep = options.Upkeep;
    ServiceComponent.m_ElectricityConsumption = options.ElectricityConsumption;
    ServiceComponent.m_WaterConsumption = options.WaterConsumption;
    ServiceComponent.m_GarbageAccumulation = options.GarbageAccumulation;
}
public void ModifyAttraction(PrefabBase prefab, IAttractionOptions options)
{
    var AttractionComponent = prefab.GetComponent<Game.Prefabs.Attraction>();
    AttractionComponent.m_Attractiveness = options.Attractiveness;
}
public void ModifyBattery(PrefabBase prefab, IBatteryOptions options)
{
    var BatteryComponent = prefab.GetComponent<Game.Prefabs.Battery>();
    BatteryComponent.m_Capacity = options.BatteryCapacity;
    BatteryComponent.m_PowerOutput = options.PowerOutput;
}
public void ModifyCargoTransportStation(PrefabBase prefab, ICargoTransportStationOptions options)
{
    var CargoTransportComponent = prefab.GetComponent<Game.Prefabs.CargoTransportStation>();
    CargoTransportComponent.transports = options.Transports;
}
public void ModifyIDeathcareFacility(PrefabBase prefab, IDeathcareFacilityOptions options)
{
    var DeathcareFacilityComponent = prefab.GetComponent<Game.Prefabs.DeathcareFacility>();
    DeathcareFacilityComponent.m_HearseCapacity = options.HearseCapacity;
    DeathcareFacilityComponent.m_StorageCapacity = options.StorageCapacity;
    DeathcareFacilityComponent.m_ProcessingRate = options.ProcessingRate;
}
public void ModifyEmergencyShelter(PrefabBase prefab, IEmergencyShelterOptions options)
{
    var ShelterComponent = prefab.GetComponent<Game.Prefabs.EmergencyShelter>();
    ShelterComponent.m_ShelterCapacity = options.ShelterCapacity;
    ShelterComponent.m_VehicleCapacity = options.VehicleCapacity;
}
public void ModifyFireStation(PrefabBase prefab, IFireStationOptions options)
{
    var FirestationComponent = prefab.GetComponent<Game.Prefabs.FireStation>();
    FirestationComponent.m_FireEngineCapacity = options.FireEngineCapacity;
    FirestationComponent.m_FireHelicopterCapacity = options.FireHelicopterCapacity;
    FirestationComponent.m_DisasterResponseCapacity = options.DisasterResponseCapacity;
    FirestationComponent.m_VehicleEfficiency = options.VehicleEfficiency;
}
public void ModifyPollution(PrefabBase prefab, IPollutionOptions options)
{
    var PollutionComponent = prefab.GetComponent<Pollution>();
    PollutionComponent.m_AirPollution = options.AirPollution;
    PollutionComponent.m_GroundPollution = options.GroundPollution;
    PollutionComponent.m_NoisePollution = options.NoisePollution;
}