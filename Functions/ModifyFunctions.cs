using Game.Buildings;
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
        TransportComponent.m_PassengerCapacity = options.PassengerCapacity;
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
    public static void ModifyHospital(PrefabBase prefab, IHospitalOptions options)
    {
        var HospitalComponent = prefab.GetComponent<Game.Prefabs.Hospital>();
        HospitalComponent.m_AmbulanceCapacity = options.AmbulanceCapacity;
        HospitalComponent.m_MedicalHelicopterCapacity = options.HelicopterCapacity;
        HospitalComponent.m_PatientCapacity = options.PatientCapacity;
        HospitalComponent.m_TreatmentBonus = options.TreatmentBonus;
    }
    public static void ModifyPostOffice(PrefabBase prefab, IPostFacilityOptions options)
    {
        var PostofficeComponent = prefab.GetComponent<Game.Prefabs.PostFacility>();
        PostofficeComponent.m_MailBoxCapacity = options.MailboxCapacity;
        PostofficeComponent.m_PostVanCapacity = options.PostVanCapacity;
        PostofficeComponent.m_MailStorageCapacity = options.MailStorageCapacity;
        PostofficeComponent.m_PostTruckCapacity = options.PostTrucksCapacity;
        PostofficeComponent.m_SortingRate = options.SortingRate;
    }
    public static void ModifyWindPowered(PrefabBase prefab, IWindPoweredOptions options)
    {
        var WindComponent = prefab.GetComponent<Game.Prefabs.WindPowered>();
        WindComponent.m_Production = options.Production;
        WindComponent.m_MaximumWind = options.MaximumWind;
    }
    public static void ModifyGroundwaterPowered(PrefabBase prefab, IGroundWaterPoweredOptions options)
    {
        var ProductionComponent = prefab.GetComponent<GroundWaterPowered>();
        ProductionComponent.m_Production = options.Production;
        ProductionComponent.m_MaximumGroundWater = options.MaximumGroundwater;
    }
    public static void ModifySolarPowered(PrefabBase prefab, ISolarPoweredOptions options)
    {
        var ProductionComponent = prefab.GetComponent<SolarPowered>();
        ProductionComponent.m_Production = options.Production;
    }
    public static void ModifyLocalWellbeing(PrefabBase prefab, ILocalWellbeing options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var WellbeingEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.Wellbeing);
        WellbeingEffect.m_Delta = options.LocalWellbeing;
        WellbeingEffect.m_Radius = options.LocalWellbeingRadius;
    }
    public static void ModifyCityImportCost(PrefabBase prefab, ICityImportcost options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityimportEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ImportCost);
        CityimportEffect.m_Delta = options.CityImportcost;
        
    }
    public static void ModifyPostVan(PrefabBase prefab, IPostVanOptions options)
    {
        var MailComponent = prefab.GetComponent<Game.Prefabs.PostVan>();
        MailComponent.m_MailCapacity = options.MailCapacity;

    }
    public static void ModifyLocalCrimeAccumulation(PrefabBase prefab, ILocalCrimeAccumulation options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var CrimeAccumulationEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.CrimeAccumulation);
        CrimeAccumulationEffect.m_Delta = options.LocalCrimeAccumulation;
        CrimeAccumulationEffect.m_Radius = options.LocalCrimeAccumulationRadius;

    }
    public static void ModifyCityOfficeEfficiency(PrefabBase prefab, ICityOfficeEfficiency options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityOfficeEfficencyEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeEfficiency);
        CityOfficeEfficencyEffect.m_Delta = options.CityOfficeEfficiency;
    }
    public static void ModifyCityUniversityInterest(PrefabBase prefab, ICityUniversityInterest options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityUniversityInterestEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityInterest);
        CityUniversityInterestEffect.m_Delta = options.CityUniversityInterest;
    }
    public static void ModifyCityUniversityGraduation(PrefabBase prefab, ICityUniversityGraduation options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityUniversityGraduationEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityGraduation);
        CityUniversityGraduationEffect.m_Delta = options.CityUniversityGraduation;
    }
    public static void ModifyLocalForestFireHazard(PrefabBase prefab, ILocalForestFireHazard options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var ForestFireHazardEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.ForestFireHazard);
        ForestFireHazardEffect.m_Delta = options.LocalForestFireHazard;
        ForestFireHazardEffect.m_Radius = options.LocalForestFireHazardRadius;
    }
    public static void ModifyLocalForestFireResponseTime(PrefabBase prefab, ILocalForestFireResponseTime options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var ForestFireResponseEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.ForestFireResponseTime);
        ForestFireResponseEffect.m_Delta = options.LocalForestFireResponseTime;
        ForestFireResponseEffect.m_Radius = options.LocalForestFireResponseTimeRadius;
    }
    public static void ModifyPoliceStation(PrefabBase prefab, IPoliceStationOptions options)
    {
        var PoliceStationComponent = prefab.GetComponent<Game.Prefabs.PoliceStation>();
        PoliceStationComponent.m_PatrolCarCapacity = options.PatrolCarCapacity;
        PoliceStationComponent.m_PoliceHelicopterCapacity = options.PoliceHelicopterCapacity;
        PoliceStationComponent.m_JailCapacity = options.JailCapacity;
    }
    public static void ModifyPrison(PrefabBase prefab, IPrisonOptions options)
    {
        var PrisonComponent = prefab.GetComponent<Game.Prefabs.Prison>();
        PrisonComponent.m_PrisonVanCapacity = options.PrisonVanCapacity;
        PrisonComponent.m_PrisonerCapacity = options.PrisonerCapacity;
    }
    public static void ModifyCityDiseaseprobability(PrefabBase prefab, ICityDiseaseprobability options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityDiseaseEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DiseaseProbability);
        CityDiseaseEffect.m_Delta = options.CityDiseaseprobability;
    }
    public static void ModifyCityPollutionhealthAffect(PrefabBase prefab, ICityPollutionhealthAffect options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityPollutionEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.PollutionHealthAffect);
        CityPollutionEffect.m_Delta = options.CityPollutionhealthAffect;
    }
    public static void ModifyCityParkEntertainment(PrefabBase prefab, ICityParkEntertainment options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityParkEntertainmentEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ParkEntertainment);
        CityParkEntertainmentEffect.m_Delta = options.CityParkEntertainment;
    }
    public static void ModifyCityOreResourceAmount(PrefabBase prefab, ICityOreResourceAmmount options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityOreAmmountEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OreResourceAmount);
        CityOreAmmountEffect.m_Delta = options.CityOreResourceAmmount;
    }
    public static void ModifyCityOilResourceAmount(PrefabBase prefab, ICityOilResourceAmmount options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityOilAmmountEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OilResourceAmount);
        CityOilAmmountEffect.m_Delta = options.CityOilResourceAmmount;
    }
    public static void ModifySchool(PrefabBase prefab, ISchoolOptions options)
    {
        var SchoolComponent = prefab.GetComponent<Game.Prefabs.School>();
        SchoolComponent.m_StudentCapacity = options.StudentCapacity;
    }
    public static void ModifyCityIndustrialEfficiency(PrefabBase prefab, ICityIndustrialEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var IndustryEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialEfficiency);
        IndustryEffect.m_Delta = options.CityIndustrialEfficiency;
    }
    public static void ModifyCityDisasterDamageRate(PrefabBase prefab, ICityDisasterDamageRate options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var DisasterDamageRateEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DisasterDamageRate);
        DisasterDamageRateEffect.m_Delta = options.CityDisasterDamageRate;
    }
    public static void ModifyCityDisasterWarningTime(PrefabBase prefab, ICityDisasterWarningTime options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var DisasterWarningTimeEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DisasterWarningTime);
        DisasterWarningTimeEffect.m_Delta = options.CityDisasterWarningTime;        
    }
    public static void ModifyCityLoanIntrest(PrefabBase prefab, ICityLoanIntrest options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var LoanEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.LoanInterest);
        LoanEffect.m_Delta = options.CityLoanIntrest;       
    }
    public static void ModifyCityExportCost(PrefabBase prefab, ICityExportCost options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var ExportEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ExportCost);
        ExportEffect.m_Delta = options.CityExportCost;
    }
    public static void ModifyCityRecoveryFailChange(PrefabBase prefab, ICityRecoverFailChange options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var RecoveryEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.RecoveryFailChange);
        RecoveryEffect.m_Delta = options.CityRecoverFailChange;        
    }
    public static void ModifyCityHospitalEfficiency(PrefabBase prefab, ICityHospitalEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var HospitalEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.HospitalEfficiency);
        HospitalEfficiencyEffect.m_Delta = options.CityHospitalEfficiency;
    }
    public static void ModifyCityOfficeSoftwareDemand(PrefabBase prefab, ICityOfficeSoftwareDemand options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var OfficeSoftwareDemandEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareDemand);
        OfficeSoftwareDemandEffect.m_Delta = options.CityOfficeSoftwareDemand;
    }
    public static void ModifyCityOfficeSoftwareEfficiency(PrefabBase prefab, ICityOfficeSoftwareEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var OfficeSoftwareEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareEfficiency);
        OfficeSoftwareEfficiencyEffect.m_Delta = options.CityOfficeSoftwareEfficiency;
    }
    public static void ModifyCityIndustrialElectronicsDemand(PrefabBase prefab, ICityIndustrialElectronicDemand options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var IndustrialElectronicDemandEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialElectronicsDemand);
        IndustrialElectronicDemandEffect.m_Delta = options.CityIndustrialElectronicDemand;
    }
    public static void ModifyCityIndustrialElectronicsEfficiency(PrefabBase prefab, ICityIndustrialElectronicEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var IndustrialElectronicEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialElectronicsEfficiency);
        IndustrialElectronicEfficiencyEffect.m_Delta = options.CityIndustrialElectronicEfficiency;
    }
    public static void ModifyPublicTransportStops(PrefabBase prefab, ITransportStopOptions options)
    {
        var StopComponent = prefab.GetComponent<TransportStop>();
        StopComponent.m_EnterDistance = options.EnterDistance;
        StopComponent.m_ExitDistance = options.ExitDistance;
        StopComponent.m_AccessDistance = options.AccessDistance;
        StopComponent.m_BoardingTime = options.BoardingTime;
        StopComponent.m_ComfortFactor = options.ComfortFactor;
        StopComponent.m_LoadingFactor = options.LoadingFactor;
    }
    public static void ModifyPublicTransportDepot(PrefabBase prefab, ITransportDepotOptions options)
    {
        var DepotsComponent = prefab.GetComponent<Game.Prefabs.TransportDepot>();
        DepotsComponent.m_VehicleCapacity = options.VehicleCapacity;
        DepotsComponent.m_MaintenanceDuration = options.MaintenanceDuration;
        DepotsComponent.m_ProductionDuration = options.ProductionDuration;
    }
    public static void ModifyPublicTransportStation(PrefabBase prefab, ITransportStationOptions options)
    {
        var TransportComponent = prefab.GetComponent<Game.Prefabs.TransportStation>();
        TransportComponent.m_ComfortFactor = options.ComfortFactor;
    }
    public static void ModifyMailbox(PrefabBase prefab, IMailboxOptions options)
    {
        var MailboxComponent = prefab.GetComponent<MailBox>();
        MailboxComponent.m_MailCapacity = options.Mailcapacity;
        MailboxComponent.m_ComfortFactor = options.ComfortFactor;
    }
    public static void ModifyDeliveryTruck(PrefabBase prefab, IDeliveryTruckOptions options)
    {
        var DeliveryTruckComponent = prefab.GetComponent<Game.Prefabs.DeliveryTruck>();
        DeliveryTruckComponent.m_CargoCapacity = options.CargoCapacity;
        DeliveryTruckComponent.m_CostToDrive = options.CostToDrive;
    }
    public static void ModifyMaintenanceVehicle(PrefabBase prefab, IMaintenanceVehicleOptions options)
    {
        var MaintenanceVehicleComponent = prefab.GetComponent<Game.Prefabs.MaintenanceVehicle>();
        MaintenanceVehicleComponent.m_MaintenanceCapacity = options.MaintenanceCapacity;
        MaintenanceVehicleComponent.m_MaintenanceRate = options.MaintenanceRate;
    }
    public static void ModifyFireEngine(PrefabBase prefab, IFireEngineOptions options)
    {
        var FireEngineComponent = prefab.GetComponent<Game.Prefabs.FireEngine>();
        FireEngineComponent.m_ExtinguishingCapacity = options.ExtinguishingCapacity;
        FireEngineComponent.m_ExtinguishingRate = options.ExtinguishingRate;
        FireEngineComponent.m_ExtinguishingSpread = options.ExtinguishingSpread;
        FireEngineComponent.m_DestroyedClearDuration = options.DestroyedClearDuration;
    }
    public static void ModifyPoliceCar(PrefabBase prefab, IPoliceCarOptions options)
    {
        var PoliceCarComponent = prefab.GetComponent<Game.Prefabs.PoliceCar>();
        PoliceCarComponent.m_CriminalCapacity = options.CriminalCapacity;
        PoliceCarComponent.m_CrimeReductionRate = options.CrimeReductionRate;
    }
    public static void ModifyTrafficSpawner(PrefabBase prefab, ITrafficSpawnerOptions options)
    {
        var TrafficspawnerComponent = prefab.GetComponent<Game.Prefabs.TrafficSpawner>();
        TrafficspawnerComponent.m_SpawnRate = options.TrafficSpawnerRate;
    }
















}