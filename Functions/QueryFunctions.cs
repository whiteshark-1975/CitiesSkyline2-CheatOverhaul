using Game.Buildings;
using Game.City;
using Game.Prefabs;
using System.Linq;


namespace WhitesharkCheatOverhaul;

public class QueryStats
{
    public static void QueryServiceConsumption(PrefabBase prefab, IServiceConsumptionOptions options)
    {
        var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
        options.Upkeep = ServiceComponent.m_Upkeep;
        options.ElectricityConsumption = ServiceComponent.m_ElectricityConsumption;
        options.WaterConsumption = ServiceComponent.m_WaterConsumption;
        options.GarbageAccumulation = ServiceComponent.m_GarbageAccumulation;
        options.TelecomNeed = ServiceComponent.m_TelecomNeed;
    }
    public static void QueryAttraction(PrefabBase prefab, IAttractionOptions options)
    {
        var AttractionComponent = prefab.GetComponent<Game.Prefabs.Attraction>();
        options.Attractiveness = AttractionComponent.m_Attractiveness;
    }
    public static void QueryBattery(PrefabBase prefab, IBatteryOptions options)
    {
        var BatteryComponent = prefab.GetComponent<Game.Prefabs.Battery>();
        options.BatteryCapacity = BatteryComponent.m_Capacity;
        options.PowerOutput = BatteryComponent.m_PowerOutput;
    }
    public static void QueryCargoTransportStation(PrefabBase prefab, ICargoTransportStationOptions options)
    {
        var CargoTransportComponent = prefab.GetComponent<Game.Prefabs.CargoTransportStation>();
        options.Transports = CargoTransportComponent.transports;
    }
    public static void QueryIDeathcareFacility(PrefabBase prefab, IDeathcareFacilityOptions options)
    {
        var DeathcareFacilityComponent = prefab.GetComponent<Game.Prefabs.DeathcareFacility>();
        options.HearseCapacity = DeathcareFacilityComponent.m_HearseCapacity;
        options.StorageCapacity = DeathcareFacilityComponent.m_StorageCapacity;
        options.ProcessingRate = DeathcareFacilityComponent.m_ProcessingRate;
    }
    public static void QueryEmergencyShelter(PrefabBase prefab, IEmergencyShelterOptions options)
    {
        var ShelterComponent = prefab.GetComponent<Game.Prefabs.EmergencyShelter>();
        options.ShelterCapacity = ShelterComponent.m_ShelterCapacity;
        options.VehicleCapacity = ShelterComponent.m_VehicleCapacity;
    }
    public static void QueryFireStation(PrefabBase prefab, IFireStationOptions options)
    {
        var FirestationComponent = prefab.GetComponent<Game.Prefabs.FireStation>();
        options.FireEngineCapacity = FirestationComponent.m_FireEngineCapacity;
        options.FireHelicopterCapacity = FirestationComponent.m_FireHelicopterCapacity;
        options.DisasterResponseCapacity = FirestationComponent.m_DisasterResponseCapacity;
        options.VehicleEfficiency = FirestationComponent.m_VehicleEfficiency;
    }
    public static void QueryPollution(PrefabBase prefab, IPollutionOptions options)
    {
        var PollutionComponent = prefab.GetComponent<Pollution>();
        options.AirPollution = PollutionComponent.m_AirPollution;
        options.GroundPollution = PollutionComponent.m_GroundPollution;
        options.NoisePollution = PollutionComponent.m_NoisePollution;
    }
    public static void QueryGarbageFacility(PrefabBase prefab, IGarbageFacilityOption options)
    {
        var GarbageComponent = prefab.GetComponent<Game.Prefabs.GarbageFacility>();
        options.GarbageCapacity = GarbageComponent.m_GarbageCapacity;
        options.GarbageVehicleCapacity = GarbageComponent.m_VehicleCapacity;
        options.GarbageTransportCapacity = GarbageComponent.m_TransportCapacity;
        options.GarbageProcessingspeed = GarbageComponent.m_ProcessingSpeed;
    }
    public static void QueryPowerPlant(PrefabBase prefab, IPowerPlantOptions options)
    {
        var ProductionComponent = prefab.GetComponent<PowerPlant>();
        options.ElectricityProduction = ProductionComponent.m_ElectricityProduction;
    }
    public static void QueryStorageLimit(PrefabBase prefab, IStorageLimitOptions options)
    {
        var StorageComponent = prefab.GetComponent<Game.Prefabs.StorageLimit>();
        options.StorageLimit = StorageComponent.storageLimit;
    }
    public static void QueryWaterPumpingStation(PrefabBase prefab, IWaterPumpingStationOptions options)
    {
        var PumpComponent = prefab.GetComponent<Game.Prefabs.WaterPumpingStation>();
        options.PumpCapacity = PumpComponent.m_Capacity;
        options.Purification = PumpComponent.m_Purification;
    }
    public static void QueryTelecomFacility(PrefabBase prefab, ITelecomFacilityOptions options)
    {
        var TelecomComponent = prefab.GetComponent<Game.Prefabs.TelecomFacility>();
        options.TelecomRange = TelecomComponent.m_Range;
        options.NetworkCapacity = TelecomComponent.m_NetworkCapacity;
    }
    public static void QueryCityEntertainment(PrefabBase prefab, ICityEntertainment options)
    {
        var EnternainmentComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var EnternainmentEffect = EnternainmentComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Entertainment);
        options.CityEntertainment = EnternainmentEffect.m_Delta;
    }
    public static void QueryCityTelecomCapacity(PrefabBase prefab, ICityTelecomCapacity options)
    {
        var CityTelecomComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var TelecomEffect = CityTelecomComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.TelecomCapacity);
        options.CityTelecomCapacity = TelecomEffect.m_Delta;
    }
    public static void QueryCityAttractiveness(PrefabBase prefab, ICityAttractiveness options)
    {
        var CityAttractivenessComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityAttractivenessEffect = CityAttractivenessComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Attractiveness);
        options.CityAttractiveness = CityAttractivenessEffect.m_Delta;
    }
    public static void QueryGarbageTruck(PrefabBase prefab, IGarbageTruckOptions options)
    {
        var GarbageComponent = prefab.GetComponent<Game.Prefabs.GarbageTruck>();
        options.GarbageTruckCapacity = GarbageComponent.m_GarbageCapacity;
        options.GarbageTruckUnloadRate = GarbageComponent.m_UnloadRate;
    }
    public static void QueryPublicTransportVehicle(PrefabBase prefab, IPublicTransportVehicle options)
    {
        var TransportComponent = prefab.GetComponent<Game.Prefabs.PublicTransport>();
        options.PassengerCapacity = TransportComponent.m_PassengerCapacity;
        options.Maintenancerange = TransportComponent.m_MaintenanceRange;
    }
    public static void QueryParkingFacility(PrefabBase prefab, IParkingFacilityOptions options)
    {
        var ParkinghallComponent = prefab.GetComponent<Game.Prefabs.ParkingFacility>();
        options.GarageCapacity = ParkinghallComponent.m_GarageMarkerCapacity;
        options.Comfortfactor = ParkinghallComponent.m_ComfortFactor;
    }
    public static void QueryServiceCoverage(PrefabBase prefab, IServiceCoverageOptions options)
    {
        var CoverageComponent = prefab.GetComponent<ServiceCoverage>();
        options.ServiceCoverageRange = CoverageComponent.m_Range;
        options.ServiceCoverageCapacity = CoverageComponent.m_Capacity;
        options.ServiceCoverageMagnitude = CoverageComponent.m_Magnitude;
    }
    public static void QueryLeisureProvider(PrefabBase prefab, ILeisureProviderOptions options)
    {
        var LeisureComponent = prefab.GetComponent<Game.Prefabs.LeisureProvider>();
        options.LeisureEfficiency = LeisureComponent.m_Efficiency;
    }
    public static void QuerySewageOutlet(PrefabBase prefab, ISewageOutletOptions options)
    {
        var SewageComponent = prefab.GetComponent<Game.Prefabs.SewageOutlet>();
        options.SewageCapacity = SewageComponent.m_Capacity;
        options.SewagePurification = SewageComponent.m_Purification;
    }
    public static void QueryGarbagePowered(PrefabBase prefab, IGarbagePoweredOptions options)
    {
        var GarbagePowerComponent = prefab.GetComponent<Game.Prefabs.GarbagePowered>();
        options.ProductionPerUnit = GarbagePowerComponent.m_ProductionPerUnit;
        options.ProductionCapacity = GarbagePowerComponent.m_Capacity;
    }
    public static void QueryCityIndustrialGroundPollution(PrefabBase prefab, ICityIndustrialGroundPollution options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityEfficencyEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialGroundPollution);
        options.CityIndustrialGroundPollution = CityEfficencyEffect.m_Delta;
    }
    public static void QueryHospital(PrefabBase prefab, IHospitalOptions options)
    {
        var HospitalComponent = prefab.GetComponent<Game.Prefabs.Hospital>();
        options.AmbulanceCapacity = HospitalComponent.m_AmbulanceCapacity;
        options.HelicopterCapacity = HospitalComponent.m_MedicalHelicopterCapacity;
        options.PatientCapacity = HospitalComponent.m_PatientCapacity;
        options.TreatmentBonus = HospitalComponent.m_TreatmentBonus;
    }
    public static void QueryPostOffice(PrefabBase prefab, IPostFacilityOptions options)
    {
        var PostofficeComponent = prefab.GetComponent<Game.Prefabs.PostFacility>();
        options.MailboxCapacity = PostofficeComponent.m_MailBoxCapacity;
        options.PostVanCapacity = PostofficeComponent.m_PostVanCapacity;
        options.MailStorageCapacity = PostofficeComponent.m_MailStorageCapacity;
        options.PostTrucksCapacity = PostofficeComponent.m_PostTruckCapacity;
        options.SortingRate = PostofficeComponent.m_SortingRate;
    }
    public static void QueryWindPowered(PrefabBase prefab, IWindPoweredOptions options)
    {
        var WindComponent = prefab.GetComponent<Game.Prefabs.WindPowered>();
        options.Production = WindComponent.m_Production;
        options.MaximumWind = WindComponent.m_MaximumWind;
    }
    public static void QueryGroundwaterPowered(PrefabBase prefab, IGroundWaterPoweredOptions options)
    {
        var ProductionComponent = prefab.GetComponent<GroundWaterPowered>();
        options.Production = ProductionComponent.m_Production;
        options.MaximumGroundwater = ProductionComponent.m_MaximumGroundWater;
    }
    public static void QuerySolarPowered(PrefabBase prefab, ISolarPoweredOptions options)
    {
        var ProductionComponent = prefab.GetComponent<SolarPowered>();
        options.Production = ProductionComponent.m_Production;
    }
    public static void QueryLocalWellbeing(PrefabBase prefab, ILocalWellbeing options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var WellbeingEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.Wellbeing);
        options.LocalWellbeing = WellbeingEffect.m_Delta;
        options.LocalWellbeingRadius = WellbeingEffect.m_Radius;
    }
    public static void QueryCityImportCost(PrefabBase prefab, ICityImportcost options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityimportEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ImportCost);
        options.CityImportcost = CityimportEffect.m_Delta;
        
    }
    public static void QueryPostVan(PrefabBase prefab, IPostVanOptions options)
    {
        var MailComponent = prefab.GetComponent<Game.Prefabs.PostVan>();
        options.MailCapacity = MailComponent.m_MailCapacity;
        
    }
    public static void QueryLocalCrimeAccumulation(PrefabBase prefab, ILocalCrimeAccumulation options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var CrimeAccumulationEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.CrimeAccumulation);
        options.LocalCrimeAccumulation = CrimeAccumulationEffect.m_Delta;
        options.LocalCrimeAccumulationRadius = CrimeAccumulationEffect.m_Radius;
        
    }
    public static void QueryCityOfficeEfficiency(PrefabBase prefab, ICityOfficeEfficiency options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityOfficeEfficencyEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeEfficiency);
        options.CityOfficeEfficiency = CityOfficeEfficencyEffect.m_Delta;
    }
    public static void QueryCityUniversityInterest(PrefabBase prefab, ICityUniversityInterest options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityUniversityInterestEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityInterest);
        options.CityUniversityInterest = CityUniversityInterestEffect.m_Delta;
    }
    public static void QueryCityUniversityGraduation(PrefabBase prefab, ICityUniversityGraduation options)
    {
        var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityUniversityGraduationEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityGraduation);
        options.CityUniversityGraduation = CityUniversityGraduationEffect.m_Delta;
    }
    public static void QueryLocalForestFireHazard(PrefabBase prefab, ILocalForestFireHazard options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var ForestFireHazardEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.ForestFireHazard);
        options.LocalForestFireHazard = ForestFireHazardEffect.m_Delta;
        options.LocalForestFireHazardRadius = ForestFireHazardEffect.m_Radius;
    }
    public static void QueryLocalForestFireResponseTime(PrefabBase prefab, ILocalForestFireResponseTime options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
        var ForestFireResponseEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.ForestFireResponseTime);
        options.LocalForestFireResponseTime = ForestFireResponseEffect.m_Delta;
        options.LocalForestFireResponseTimeRadius = ForestFireResponseEffect.m_Radius;
    }
    public static void QueryPoliceStation(PrefabBase prefab, IPoliceStationOptions options)
    {
        var PoliceStationComponent = prefab.GetComponent<Game.Prefabs.PoliceStation>();
        options.PatrolCarCapacity = PoliceStationComponent.m_PatrolCarCapacity;
        options.PoliceHelicopterCapacity = PoliceStationComponent.m_PoliceHelicopterCapacity;
        options.JailCapacity = PoliceStationComponent.m_JailCapacity;
    }
    public static void QueryPrison(PrefabBase prefab, IPrisonOptions options)
    {
        var PrisonComponent = prefab.GetComponent<Game.Prefabs.Prison>();
        options.PrisonVanCapacity = PrisonComponent.m_PrisonVanCapacity;
        options.PrisonerCapacity = PrisonComponent.m_PrisonerCapacity;
    }
    public static void QueryCityDiseaseprobability(PrefabBase prefab, ICityDiseaseprobability options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityDiseaseEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DiseaseProbability);
        options.CityDiseaseprobability = CityDiseaseEffect.m_Delta;
    }
    public static void QueryCityPollutionhealthAffect(PrefabBase prefab, ICityPollutionhealthAffect options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityPollutionEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.PollutionHealthAffect);
        options.CityPollutionhealthAffect = CityPollutionEffect.m_Delta;
    }
    public static void QueryCityParkEntertainment(PrefabBase prefab, ICityParkEntertainment options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityParkEntertainmentEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ParkEntertainment);
        options.CityParkEntertainment = CityParkEntertainmentEffect.m_Delta;
    }
    public static void QueryCityOreResourceAmount(PrefabBase prefab, ICityOreResourceAmmount options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityOreAmmountEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OreResourceAmount);
        options.CityOreResourceAmmount = CityOreAmmountEffect.m_Delta;
    }
    public static void QueryCityOilResourceAmount(PrefabBase prefab, ICityOilResourceAmmount options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var CityOilAmmountEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OilResourceAmount);
        options.CityOilResourceAmmount = CityOilAmmountEffect.m_Delta;
    }
    public static void QuerySchool(PrefabBase prefab, ISchoolOptions options)
    {
        var SchoolComponent = prefab.GetComponent<Game.Prefabs.School>();
        options.StudentCapacity = SchoolComponent.m_StudentCapacity;
    }
    public static void QueryCityIndustrialEfficiency(PrefabBase prefab, ICityIndustrialEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var IndustryEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialEfficiency);
        options.CityIndustrialEfficiency = IndustryEffect.m_Delta;
    }
    public static void QueryCityDisasterDamageRate(PrefabBase prefab, ICityDisasterDamageRate options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var DisasterDamageRateEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DisasterDamageRate);
        options.CityDisasterDamageRate = DisasterDamageRateEffect.m_Delta;
    }
    public static void QueryCityDisasterWarningTime(PrefabBase prefab, ICityDisasterWarningTime options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var DisasterWarningTimeEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DisasterWarningTime);
        options.CityDisasterWarningTime = DisasterWarningTimeEffect.m_Delta;
    }
    public static void QueryCityLoanIntrest(PrefabBase prefab, ICityLoanIntrest options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var LoanEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.LoanInterest);
        options.CityLoanIntrest = LoanEffect.m_Delta;
    }
    public static void QueryCityExportCost(PrefabBase prefab, ICityExportCost options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var ExportEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ExportCost);
        options.CityExportCost = ExportEffect.m_Delta;
    }
    public static void QueryCityRecoveryFailChange(PrefabBase prefab, ICityRecoverFailChange options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var RecoveryEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.RecoveryFailChange);
        options.CityRecoverFailChange = RecoveryEffect.m_Delta;
    }
    public static void QueryCityHospitalEfficiency(PrefabBase prefab, ICityHospitalEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var HospitalEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.HospitalEfficiency);
        options.CityHospitalEfficiency = HospitalEfficiencyEffect.m_Delta;
    }
    public static void QueryCityOfficeSoftwareDemand(PrefabBase prefab, ICityOfficeSoftwareDemand options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var OfficeSoftwareDemandEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareDemand);
        options.CityOfficeSoftwareDemand = OfficeSoftwareDemandEffect.m_Delta;
    }
    public static void QueryCityOfficeSoftwareEfficiency(PrefabBase prefab, ICityOfficeSoftwareEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var OfficeSoftwareEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareEfficiency);
        options.CityOfficeSoftwareEfficiency = OfficeSoftwareEfficiencyEffect.m_Delta;
    }
    public static void QueryCityIndustrialElectronicsDemand(PrefabBase prefab, ICityIndustrialElectronicDemand options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var IndustrialElectronicDemandEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialElectronicsDemand);
        options.CityIndustrialElectronicDemand = IndustrialElectronicDemandEffect.m_Delta;
    }
    public static void QueryCityIndustrialElectronicsEfficiency(PrefabBase prefab, ICityIndustrialElectronicEfficiency options)
    {
        var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
        var IndustrialElectronicEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialElectronicsEfficiency);
        options.CityIndustrialElectronicEfficiency = IndustrialElectronicEfficiencyEffect.m_Delta;
    }
    public static void QueryPublicTransportStops(PrefabBase prefab, ITransportStopOptions options)
    {
        var StopComponent = prefab.GetComponent<TransportStop>();
        options.EnterDistance = StopComponent.m_EnterDistance;
        options.ExitDistance = StopComponent.m_ExitDistance;
        options.AccessDistance = StopComponent.m_AccessDistance;
        options.BoardingTime = StopComponent.m_BoardingTime;
        options.ComfortFactor = StopComponent.m_ComfortFactor;
        options.LoadingFactor = StopComponent.m_LoadingFactor;
    }
    public static void QueryPublicTransportDepot(PrefabBase prefab, ITransportDepotOptions options)
    {
        var DepotsComponent = prefab.GetComponent<Game.Prefabs.TransportDepot>();
        options.VehicleCapacity = DepotsComponent.m_VehicleCapacity;
        options.MaintenanceDuration = DepotsComponent.m_MaintenanceDuration;
        options.ProductionDuration = DepotsComponent.m_ProductionDuration;
    }
    public static void QueryPublicTransportStation(PrefabBase prefab, ITransportStationOptions options)
    {
        var TransportComponent = prefab.GetComponent<Game.Prefabs.TransportStation>();
        options.ComfortFactor = TransportComponent.m_ComfortFactor;
    }
    public static void QueryMailbox(PrefabBase prefab, IMailboxOptions options)
    {
        var MailboxComponent = prefab.GetComponent<MailBox>();
        options.Mailcapacity = MailboxComponent.m_MailCapacity;
        options.ComfortFactor = MailboxComponent.m_ComfortFactor;
    }
    public static void QueryDeliveryTruck(PrefabBase prefab, IDeliveryTruckOptions options)
    {
        var DeliveryTruckComponent = prefab.GetComponent<Game.Prefabs.DeliveryTruck>();
        options.CargoCapacity = DeliveryTruckComponent.m_CargoCapacity;
        options.CostToDrive = DeliveryTruckComponent.m_CostToDrive;
    }
    public static void QueryMaintenanceVehicle(PrefabBase prefab, IMaintenanceVehicleOptions options)
    {
        var MaintenanceVehicleComponent = prefab.GetComponent<Game.Prefabs.MaintenanceVehicle>();
        options.MaintenanceCapacity = MaintenanceVehicleComponent.m_MaintenanceCapacity;
        options.MaintenanceRate = MaintenanceVehicleComponent.m_MaintenanceRate;
    }
    public static void QueryFireEngine(PrefabBase prefab, IFireEngineOptions options)
    {
        var FireEngineComponent = prefab.GetComponent<Game.Prefabs.FireEngine>();
        options.ExtinguishingCapacity = FireEngineComponent.m_ExtinguishingCapacity;
        options.ExtinguishingRate = FireEngineComponent.m_ExtinguishingRate;
        options.ExtinguishingSpread = FireEngineComponent.m_ExtinguishingSpread;
        options.DestroyedClearDuration = FireEngineComponent.m_DestroyedClearDuration;
    }
    public static void QueryPoliceCar(PrefabBase prefab, IPoliceCarOptions options)
    {
        var PoliceCarComponent = prefab.GetComponent<Game.Prefabs.PoliceCar>();
        options.CriminalCapacity = PoliceCarComponent.m_CriminalCapacity;
        options.CrimeReductionRate = PoliceCarComponent.m_CrimeReductionRate;
    }
    public static void QueryTrafficSpawner(PrefabBase prefab, ITrafficSpawnerOptions options)
    {
        var TrafficspawnerComponent = prefab.GetComponent<Game.Prefabs.TrafficSpawner>();
        options.TrafficSpawnerRate = TrafficspawnerComponent.m_SpawnRate;
    }

    public static void QueryMaintenanceDepot(PrefabBase prefab, IMaintenanceDepotOptions options)
    {
        var MaintenanceDepotComponent = prefab.GetComponent<Game.Prefabs.MaintenanceDepot>();
        options.VehicleCapacity = MaintenanceDepotComponent.m_VehicleCapacity;
        options.VehicleEfficiency = MaintenanceDepotComponent.m_VehicleEfficiency;
    }
}