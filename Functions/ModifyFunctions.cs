using Game.City;
using Game.Prefabs;
using System.Linq;

namespace WhitesharkCheatOverhaul;

public class ModifyStats
{
    public static void ModifyServiceConsumption(PrefabBase prefab, IServiceConsumptionOptions options)
    {
        var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
        ServiceComponent.m_Upkeep = options.Upkeep;
        ServiceComponent.m_ElectricityConsumption = options.ElectricityConsumption;
        ServiceComponent.m_WaterConsumption = options.WaterConsumption;
        ServiceComponent.m_GarbageAccumulation = options.GarbageAccumulation;
    }
    public static void ModifyAttraction(PrefabBase prefab, IAttractionOptions options)
    {
        var AttractionComponent = prefab.GetComponent<Game.Prefabs.Attraction>();
        AttractionComponent.m_Attractiveness = options.Attractiveness;
    }
    public static void ModifyBattery(PrefabBase prefab, IBatteryOptions options)
    {
        var BatteryComponent = prefab.GetComponent<Game.Prefabs.Battery>();
        BatteryComponent.m_Capacity = options.BatteryCapacity;
        BatteryComponent.m_PowerOutput = options.PowerOutput;
    }
    public static void ModifyCargoTransportStation(PrefabBase prefab, ICargoTransportStationOptions options)
    {
        var CargoTransportComponent = prefab.GetComponent<Game.Prefabs.CargoTransportStation>();
        CargoTransportComponent.transports = options.Transports;
    }
    public static void ModifyIDeathcareFacility(PrefabBase prefab, IDeathcareFacilityOptions options)
    {
        var DeathcareFacilityComponent = prefab.GetComponent<Game.Prefabs.DeathcareFacility>();
        DeathcareFacilityComponent.m_HearseCapacity = options.HearseCapacity;
        DeathcareFacilityComponent.m_StorageCapacity = options.StorageCapacity;
        DeathcareFacilityComponent.m_ProcessingRate = options.ProcessingRate;
    }
    public static void ModifyEmergencyShelter(PrefabBase prefab, IEmergencyShelterOptions options)
    {
        var ShelterComponent = prefab.GetComponent<Game.Prefabs.EmergencyShelter>();
        ShelterComponent.m_ShelterCapacity = options.ShelterCapacity;
        ShelterComponent.m_VehicleCapacity = options.VehicleCapacity;
    }
    public static void ModifyFireStation(PrefabBase prefab, IFireStationOptions options)
    {
        var FirestationComponent = prefab.GetComponent<Game.Prefabs.FireStation>();
        FirestationComponent.m_FireEngineCapacity = options.FireEngineCapacity;
        FirestationComponent.m_FireHelicopterCapacity = options.FireHelicopterCapacity;
        FirestationComponent.m_DisasterResponseCapacity = options.DisasterResponseCapacity;
        FirestationComponent.m_VehicleEfficiency = options.VehicleEfficiency;
    }
    public static void ModifyPollution(PrefabBase prefab, IPollutionOptions options)
    {
        var PollutionComponent = prefab.GetComponent<Pollution>();
        PollutionComponent.m_AirPollution = options.AirPollution;
        PollutionComponent.m_GroundPollution = options.GroundPollution;
        PollutionComponent.m_NoisePollution = options.NoisePollution;
    }
    public static void ModifyGarbageFacility(PrefabBase prefab, IGarbageFacilityOption options)
    {
        var GarbageComponent = prefab.GetComponent<Game.Prefabs.GarbageFacility>();
        GarbageComponent.m_GarbageCapacity = options.GarbageCapacity;
        GarbageComponent.m_VehicleCapacity = options.GarbageVehicleCapacity;
        GarbageComponent.m_TransportCapacity = options.GarbageTransportCapacity;
        GarbageComponent.m_ProcessingSpeed = options.GarbageProcessingspeed;
    }
    public static void ModifyPowerPlant(PrefabBase prefab, IPowerPlantOptions options)
    {
        var ProductionComponent = prefab.GetComponent<PowerPlant>();
        ProductionComponent.m_ElectricityProduction = options.ElectricityProduction;
    }
    public static void ModifyStorageLimit(PrefabBase prefab, IStorageLimitOptions options)
    {
        var StorageComponent = prefab.GetComponent<Game.Prefabs.StorageLimit>();
        StorageComponent.storageLimit = options.StorageLimit;
    }
    public static void ModifyWaterPumpingStation(PrefabBase prefab, IWaterPumpingStationOptions options)
    {
        var PumpComponent = prefab.GetComponent<Game.Prefabs.WaterPumpingStation>();
        PumpComponent.m_Capacity = options.PumpCapacity;
        PumpComponent.m_Purification = options.Purification;
    }
    public static void ModifyTelecomFacility(PrefabBase prefab, ITelecomFacilityOptions options)
    {
        var TelecomComponent = prefab.GetComponent<Game.Prefabs.TelecomFacility>();
        TelecomComponent.m_Range = options.TelecomRange;
        TelecomComponent.m_NetworkCapacity = options.NetworkCapacity;
    }
    public static void ModifyCityEntertainment(PrefabBase prefab, ICityEntertainment options)
    {
        var EnternainmentComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var EnternainmentEffect = EnternainmentComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Entertainment);
        EnternainmentEffect.m_Delta = options.CityEntertainment;
    }
    public static void ModifyCityTelecomCapacity(PrefabBase prefab, ICityTelecomCapacity options)
    {
        var CityTelecomComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var TelecomEffect = CityTelecomComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.TelecomCapacity);
        TelecomEffect.m_Delta = options.CityTelecomCapacity;
    }
    public static void ModifyCityAttractiveness(PrefabBase prefab, ICityAttractiveness options)
    {
        var CityAttractivenessComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityAttractivenessEffect = CityAttractivenessComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Attractiveness);
        CityAttractivenessEffect.m_Delta = options.CityAttractiveness;
    }
    public static void ModifyGarbageTruck(PrefabBase prefab, IGarbageTruckOptions options)
    {
        var GarbageComponent = prefab.GetComponent<Game.Prefabs.GarbageTruck>();
        GarbageComponent.m_GarbageCapacity = options.GarbageTruckCapacity;
        GarbageComponent.m_UnloadRate = options.GarbageTruckUnloadRate;
    }
    public static void ModifyPublicTransportVehicle(PrefabBase prefab, IPublicTransportVehicle options)
    {
        var TransportComponent = prefab.GetComponent<Game.Prefabs.PublicTransport>();
        TransportComponent.m_PassengerCapacity = options.Passengercapacity;
        TransportComponent.m_MaintenanceRange = options.Maintenancerange;
    }
    public static void ModifyParkingFacility(PrefabBase prefab, IParkingFacilityOptions options)
    {
        var ParkinghallComponent = prefab.GetComponent<Game.Prefabs.ParkingFacility>();
        ParkinghallComponent.m_GarageMarkerCapacity = options.GarageCapacity;
        ParkinghallComponent.m_ComfortFactor = options.Comfortfactor;
    }
    public static void ModifyServiceCoverage(PrefabBase prefab, IServiceCoverageOptions options)
    {
        var CoverageComponent = prefab.GetComponent<ServiceCoverage>();
        CoverageComponent.m_Range = options.ServiceCoverageRange;
        CoverageComponent.m_Capacity = options.ServiceCoverageCapacity;
        CoverageComponent.m_Magnitude = options.ServiceCoverageMagnitude;
    }
    public static void ModifyLeisureProvider(PrefabBase prefab, ILeisureProviderOptions options)
    {
        var LeisureComponent = prefab.GetComponent<Game.Prefabs.LeisureProvider>();
        LeisureComponent.m_Efficiency = options.LeisureEfficiency;
    }
    public static void ModifySewageOutlet(PrefabBase prefab, ISewageOutletOptions options)
    {
        var SewageComponent = prefab.GetComponent<Game.Prefabs.SewageOutlet>();
        SewageComponent.m_Capacity = options.SewageCapacity;
        SewageComponent.m_Purification = options.SewagePurification;
    }
    public static void ModifyGarbagePowered(PrefabBase prefab, IGarbagePoweredOptions options)
    {
        var GarbagePowerComponent = prefab.GetComponent<Game.Prefabs.GarbagePowered>();
        GarbagePowerComponent.m_ProductionPerUnit = options.ProductionPerUnit;
        GarbagePowerComponent.m_Capacity = options.ProductionCapacity;
    }
    public static void ModifyCityIndustrialGroundPollution(PrefabBase prefab, ICityIndustrialGroundPollution options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityEfficencyEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialGroundPollution);
        CityEfficencyEffect.m_Delta = options.CityIndustrialGroundPollution;
    }



















































}