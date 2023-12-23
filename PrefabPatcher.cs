using Game.Areas;
using Game.Buildings;
using Game.City;
using Game.Prefabs;
using HarmonyLib;
using System.Linq;
using System;


namespace WhitesharkCheatOverhaul;

[HarmonyPatch(typeof(PrefabSystem), "AddPrefab")]
public static class PrefabPatcher
{
    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (WhitesharkCheatOverhaul.SchoolOptions.TryGetValue(prefab.name, out SchoolOptions SchoolOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, SchoolOptions);
            ModifyStats.ModifyPollution(prefab, SchoolOptions);
        }
        if (WhitesharkCheatOverhaul.PowerplantOptions.TryGetValue(prefab.name, out PowerplantOptions PowerplantOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, PowerplantOptions);
            
            if (
                prefab.name != "GasPowerPlant01 Advanced Furnace" &&
                prefab.name != "GasPowerPlant01 Exhaust Filter" &&
                prefab.name != "CoalPowerPlant01 Advanced Furnace" &&
                prefab.name != "CoalPowerPlant01 Exhaust Filter"
                )
            {
                ModifyStats.ModifyPollution(prefab, PowerplantOptions);
            }
            if (
                prefab.name != "GasPowerPlant01 Advanced Furnace" &&
                prefab.name != "GasPowerPlant01 Exhaust Filter" &&
                prefab.name != "GasPowerPlant01 Fuel Storage Extention" &&
                prefab.name != "CoalPowerPlant01 Advanced Furnace" &&
                prefab.name != "CoalPowerPlant01 Exhaust Filter" &&
                prefab.name != "CoalPowerPlant01 Coal Storage Yard"
                )
            {
                ModifyStats.ModifyPowerPlant(prefab, PowerplantOptions);
            }
            if (
                prefab.name == "GasPowerPlant01 Fuel Storage Extention" || 
                prefab.name == "GasPowerPlant01" || 
                prefab.name == "CoalPowerPlant01" ||
                prefab.name == "CoalPowerPlant01 Coal Storage Yard"
                )
            {
                ModifyStats.ModifyStorageLimit(prefab, PowerplantOptions);
            }
        }
        if (WhitesharkCheatOverhaul.WaterpumpOptions.TryGetValue(prefab.name, out WaterpumpOptions WaterpumpOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, WaterpumpOptions);
            if (prefab.name != "GroundwaterPumpingStation01 Advanced Filtering System")
            {
                ModifyStats.ModifyPollution(prefab, WaterpumpOptions);
            }
            ModifyStats.ModifyWaterPumpingStation(prefab, WaterpumpOptions);
        }
        if (WhitesharkCheatOverhaul.TransformerstationOptions.TryGetValue(prefab.name, out TransformerstationOptions TransformerstationOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, TransformerstationOptions);
            ModifyStats.ModifyPollution(prefab, TransformerstationOptions);
        }
        if (WhitesharkCheatOverhaul.ServerfarmOptions.TryGetValue(prefab.name, out ServerfarmOptions ServerfarmOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, ServerfarmOptions);
            ModifyStats.ModifyTelecomFacility(prefab, ServerfarmOptions);
            if (prefab.name == "ServerFarm01" || prefab.name == "SatelliteUplink01")
            {
                ModifyStats.ModifyPollution(prefab, ServerfarmOptions);
            }
            if (prefab.name == "SatelliteUplink01")
            {
                ModifyStats.ModifyCityEntertainment(prefab, ServerfarmOptions);
                ModifyStats.ModifyCityTelecomCapacity(prefab, ServerfarmOptions);
                ModifyStats.ModifyCityAttractiveness(prefab, ServerfarmOptions);
            }
        }
        if (WhitesharkCheatOverhaul.GarbagetruckOptions.TryGetValue(prefab.name, out GarbagetruckOptions GarbagetruckOptions))
        {
            ModifyStats.ModifyGarbageTruck(prefab, GarbagetruckOptions);
        }
        if (WhitesharkCheatOverhaul.PublicTransportVehicleOptions.TryGetValue(prefab.name, out PublicTransportVehicleOptions PublicTransportVehicleOptions))
        {
            ModifyStats.ModifyPublicTransportVehicle(prefab, PublicTransportVehicleOptions);
        }
        if (WhitesharkCheatOverhaul.ParkinghallOptions.TryGetValue(prefab.name, out ParkinghallOptions ParkinghallOptions))
        {
            ModifyStats.ModifyParkingFacility(prefab, ParkinghallOptions);
            ModifyStats.ModifyServiceConsumption(prefab, ParkinghallOptions);
            if (prefab.name != "ParkingHall01 Car Wash")
            {
                ModifyStats.ModifyPollution(prefab, ParkinghallOptions);
            }  
        }
        if (WhitesharkCheatOverhaul.CityparkOptions.TryGetValue(prefab.name, out CityparkOptions CityparkOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, CityparkOptions);
            ModifyStats.ModifyServiceCoverage(prefab, CityparkOptions);
            ModifyStats.ModifyAttraction(prefab, CityparkOptions);
            ModifyStats.ModifyLeisureProvider(prefab, CityparkOptions);
        }
        if (WhitesharkCheatOverhaul.WastewaterOptions.TryGetValue(prefab.name, out WastewaterOptions WastewaterOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, WastewaterOptions);
            ModifyStats.ModifyPollution(prefab, WastewaterOptions);
            ModifyStats.ModifySewageOutlet(prefab, WastewaterOptions);
        }
        if (WhitesharkCheatOverhaul.IncinerationPlantOptions.TryGetValue(prefab.name, out IncinerationPlantOptions IncinerationPlantOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, IncinerationPlantOptions);
            ModifyStats.ModifyPollution(prefab, IncinerationPlantOptions);
            ModifyStats.ModifyGarbageFacility(prefab, IncinerationPlantOptions);
            if (prefab.name == "IncinerationPlant01")
            {
                ModifyStats.ModifyPowerPlant(prefab, IncinerationPlantOptions);
                ModifyStats.ModifyGarbagePowered(prefab, IncinerationPlantOptions);                               
            }
            if (prefab.name == "HazardousWasteProcessingSite01")
            {
                ModifyStats.ModifyCityIndustrialGroundPollution(prefab, IncinerationPlantOptions);
            }
        }
        if (WhitesharkCheatOverhaul.HealthcareOptions.TryGetValue(prefab.name, out HealthcareOptions HealthcareOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, HealthcareOptions);
            ModifyStats.ModifyHospital(prefab, HealthcareOptions);
            if (prefab.name == "MedicalClinic01" || prefab.name == "Hospital01")
            {
                ModifyStats.ModifyServiceCoverage(prefab, HealthcareOptions);
            }
        }
        if (WhitesharkCheatOverhaul.PostofficeOptions.TryGetValue(prefab.name, out PostofficeOptions PostofficeOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, PostofficeOptions);
            ModifyStats.ModifyPostOffice(prefab, PostofficeOptions);
            if (prefab.name == "PostOffice01")
            {
                ModifyStats.ModifyServiceCoverage(prefab, PostofficeOptions);
            }
            if (
                prefab.name != "PostSortingFacility01 Automated Sorting"
                )
            {
                ModifyStats.ModifyPollution(prefab, PostofficeOptions);
            }            
        }
        if (WhitesharkCheatOverhaul.CemeteryOptions.TryGetValue(prefab.name, out CemeteryOptions CemeteryOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, CemeteryOptions);
            ModifyStats.ModifyIDeathcareFacility(prefab, CemeteryOptions);
            ModifyStats.ModifyLeisureProvider(prefab, CemeteryOptions);
        }
        if (WhitesharkCheatOverhaul.CrematoriumOptions.TryGetValue(prefab.name, out CrematoriumOptions CrematoriumOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, CrematoriumOptions);
            ModifyStats.ModifyPollution(prefab, CrematoriumOptions);
            ModifyStats.ModifyIDeathcareFacility(prefab, CrematoriumOptions);            
        }
        if (WhitesharkCheatOverhaul.WindturbineOptions.TryGetValue(prefab.name, out WindturbineOptions WindturbineOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, WindturbineOptions);
            ModifyStats.ModifyPollution(prefab, WindturbineOptions);
            ModifyStats.ModifyWindPowered(prefab, WindturbineOptions);
        }
        if (WhitesharkCheatOverhaul.EmergencybatteryOptions.TryGetValue(prefab.name, out EmergencybatteryOptions EmergencybatteryOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, EmergencybatteryOptions);
            ModifyStats.ModifyPollution(prefab, EmergencybatteryOptions);
            ModifyStats.ModifyBattery(prefab, EmergencybatteryOptions);            
        }
        if (WhitesharkCheatOverhaul.GeothermalpowerplantOptions.TryGetValue(prefab.name, out GeothermalpowerplantOptions GeothermalpowerplantOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, GeothermalpowerplantOptions);
            ModifyStats.ModifyPollution(prefab, GeothermalpowerplantOptions);
            ModifyStats.ModifyGroundwaterPowered(prefab, GeothermalpowerplantOptions);          
        }
        if (WhitesharkCheatOverhaul.SolarpowerstationOptions.TryGetValue(prefab.name, out SolarpowerstationOptions SolarpowerstationOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, SolarpowerstationOptions);
            ModifyStats.ModifyPollution(prefab, SolarpowerstationOptions);
            ModifyStats.ModifySolarPowered(prefab, SolarpowerstationOptions);
            ModifyStats.ModifyBattery(prefab, SolarpowerstationOptions);
        }
        if (WhitesharkCheatOverhaul.SignatureResidentialbuildingOptions.TryGetValue(prefab.name, out SignatureResidentialbuildingOptions SignatureResidentialbuildingOptions))
        {
            ModifyStats.ModifyLocalWellbeing(prefab, SignatureResidentialbuildingOptions);
        }
        if (WhitesharkCheatOverhaul.SignatureCommercialbuildingOptions.TryGetValue(prefab.name, out SignatureCommercialbuildingOptions SignatureCommercialbuildingOptions))
        {
            ModifyStats.ModifyAttraction(prefab, SignatureCommercialbuildingOptions);
            ModifyStats.ModifyLocalWellbeing(prefab, SignatureCommercialbuildingOptions);
            ModifyStats.ModifyPollution(prefab, SignatureCommercialbuildingOptions);
            ModifyStats.ModifyCityAttractiveness(prefab, SignatureCommercialbuildingOptions);
            ModifyStats.ModifyCityImportCost(prefab, SignatureCommercialbuildingOptions);
        }
        if (WhitesharkCheatOverhaul.PostVanOptions.TryGetValue(prefab.name, out var PostVanOptions))
        {
            ModifyStats.ModifyPostVan(prefab, PostVanOptions);             
        }
        if (WhitesharkCheatOverhaul.SignatureOfficebuildingOptions.TryGetValue(prefab.name, out SignatureOfficebuildingOptions SignatureOfficebuildingOptions))
        {
            ModifyStats.ModifyAttraction(prefab, SignatureOfficebuildingOptions);
            ModifyStats.ModifyLocalWellbeing(prefab, SignatureOfficebuildingOptions);
            ModifyStats.ModifyPollution(prefab, SignatureOfficebuildingOptions);
            if (prefab.name == "OfficeLowSignature01")
            {
                ModifyStats.ModifyLocalCrimeAccumulation(prefab, SignatureOfficebuildingOptions);
            }
            ModifyStats.ModifyCityOfficeEfficiency(prefab, SignatureOfficebuildingOptions);
            ModifyStats.ModifyCityUniversityInterest(prefab, SignatureOfficebuildingOptions);
            ModifyStats.ModifyCityUniversityGraduation(prefab, SignatureOfficebuildingOptions);
        }
        if (WhitesharkCheatOverhaul.SignatureMixedbuildingOptions.TryGetValue(prefab.name, out SignatureMixedbuildingOptions SignatureMixedbuildingOptions))
        {
            ModifyStats.ModifyAttraction(prefab, SignatureMixedbuildingOptions);
            ModifyStats.ModifyLocalWellbeing(prefab, SignatureMixedbuildingOptions);
            ModifyStats.ModifyPollution(prefab, SignatureMixedbuildingOptions);
            ModifyStats.ModifyCityAttractiveness(prefab, SignatureMixedbuildingOptions);            
        }
        if (WhitesharkCheatOverhaul.FireStationOptions.TryGetValue(prefab.name, out FireStationOptions FireStationOptions))
        {            
            ModifyStats.ModifyServiceConsumption(prefab, FireStationOptions);
            ModifyStats.ModifyPollution(prefab, FireStationOptions);
            ModifyStats.ModifyServiceCoverage(prefab, FireStationOptions);
            ModifyStats.ModifyFireStation(prefab, FireStationOptions);
        }
        if (WhitesharkCheatOverhaul.FireHelicopterDepotOptions.TryGetValue(prefab.name, out FireHelicopterDepotOptions FireHelicopterDepotOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, FireHelicopterDepotOptions);
            ModifyStats.ModifyPollution(prefab, FireHelicopterDepotOptions);
            ModifyStats.ModifyFireStation(prefab, FireHelicopterDepotOptions);            
        }
        if (WhitesharkCheatOverhaul.FirewatchTowerOptions.TryGetValue(prefab.name, out FirewatchTowerOptions FirewatchTowerOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, FirewatchTowerOptions);
            ModifyStats.ModifyLocalForestFireHazard(prefab, FirewatchTowerOptions);
            ModifyStats.ModifyLocalForestFireResponseTime(prefab, FirewatchTowerOptions);
        }
        if (WhitesharkCheatOverhaul.PoliceStationOptions.TryGetValue(prefab.name, out PoliceStationOptions PoliceStationOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, PoliceStationOptions);
            ModifyStats.ModifyPollution(prefab, PoliceStationOptions);
            ModifyStats.ModifyPoliceStation(prefab, PoliceStationOptions);
            ModifyStats.ModifyServiceCoverage(prefab, PoliceStationOptions);
        }
        if (WhitesharkCheatOverhaul.PrisonOptions.TryGetValue(prefab.name, out PrisonOptions PrisonOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, PrisonOptions);
            ModifyStats.ModifyPollution(prefab, PrisonOptions);
            ModifyStats.ModifyPrison(prefab, PrisonOptions);
            ModifyStats.ModifyLocalCrimeAccumulation(prefab, PrisonOptions);     
        }
        if (WhitesharkCheatOverhaul.DiseaseControlCenterOptions.TryGetValue(prefab.name, out DiseaseControlCenterOptions DiseaseControlCenterOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, DiseaseControlCenterOptions);
            ModifyStats.ModifyHospital(prefab, DiseaseControlCenterOptions);
            ModifyStats.ModifyCityDiseaseprobability(prefab, DiseaseControlCenterOptions);
            ModifyStats.ModifyCityPollutionhealthAffect(prefab, DiseaseControlCenterOptions);
        }
        if (WhitesharkCheatOverhaul.HeathResearchInstituteOptions.TryGetValue(prefab.name, out HeathResearchInstituteOptions HeathResearchInstituteOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, HeathResearchInstituteOptions);
            ModifyStats.ModifyCityDiseaseprobability(prefab, HeathResearchInstituteOptions);
            ModifyStats.ModifyCityParkEntertainment(prefab, HeathResearchInstituteOptions);
        }
        if (WhitesharkCheatOverhaul.RadioTelescopeOptions.TryGetValue(prefab.name, out RadioTelescopeOptions RadioTelescopeOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, RadioTelescopeOptions);
            ModifyStats.ModifyCityUniversityGraduation(prefab, RadioTelescopeOptions);
        }
        if (WhitesharkCheatOverhaul.GeologicalResearchCenterOptions.TryGetValue(prefab.name, out GeologicalResearchCenterOptions GeologicalResearchCenterOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, GeologicalResearchCenterOptions);
            ModifyStats.ModifyPollution(prefab, GeologicalResearchCenterOptions);
            ModifyStats.ModifyCityOreResourceAmount(prefab, GeologicalResearchCenterOptions);
            ModifyStats.ModifyCityOilResourceAmount(prefab, GeologicalResearchCenterOptions);
        }
        if (WhitesharkCheatOverhaul.TechnicalUniversityOptions.TryGetValue(prefab.name, out TechnicalUniversityOptions TechnicalUniversityOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, TechnicalUniversityOptions);
            ModifyStats.ModifyPollution(prefab, TechnicalUniversityOptions);
            ModifyStats.ModifySchool(prefab, TechnicalUniversityOptions);
            ModifyStats.ModifyCityIndustrialEfficiency(prefab, TechnicalUniversityOptions);
            ModifyStats.ModifyCityOfficeEfficiency(prefab, TechnicalUniversityOptions);
        }
        if (WhitesharkCheatOverhaul.EarlyDisasterWarningSystemOptions.TryGetValue(prefab.name, out EarlyDisasterWarningSystemOptions EarlyDisasterWarningSystemOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, EarlyDisasterWarningSystemOptions);
            ModifyStats.ModifyCityDisasterDamageRate(prefab, EarlyDisasterWarningSystemOptions);
            ModifyStats.ModifyCityDisasterWarningTime(prefab, EarlyDisasterWarningSystemOptions);
        }
        if (WhitesharkCheatOverhaul.WelfareOfficeOptions.TryGetValue(prefab.name, out WelfareOfficeOptions WelfareOfficeOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, WelfareOfficeOptions);
            ModifyStats.ModifyServiceCoverage(prefab, WelfareOfficeOptions);
            ModifyStats.ModifyPollution(prefab, WelfareOfficeOptions);
        }
        if (WhitesharkCheatOverhaul.CityHallOptions.TryGetValue(prefab.name, out CityHallOptions CityHallOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, CityHallOptions);
            ModifyStats.ModifyCityLoanIntrest(prefab, CityHallOptions);
            ModifyStats.ModifyCityImportCost(prefab, CityHallOptions);
        }
        if (WhitesharkCheatOverhaul.LargeEmergencyShelterOptions.TryGetValue(prefab.name, out LargeEmergencyShelterOptions LargeEmergencyShelterOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, LargeEmergencyShelterOptions);
            ModifyStats.ModifyServiceCoverage(prefab, LargeEmergencyShelterOptions);
            ModifyStats.ModifyEmergencyShelter(prefab, LargeEmergencyShelterOptions);
        }
        if (WhitesharkCheatOverhaul.CentralBankOptions.TryGetValue(prefab.name, out CentralBankOptions CentralBankOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, CentralBankOptions);
            ModifyStats.ModifyCityLoanIntrest(prefab, CentralBankOptions);
            ModifyStats.ModifyCityImportCost(prefab, CentralBankOptions);
            ModifyStats.ModifyCityExportCost(prefab, CentralBankOptions);
        }
        if (WhitesharkCheatOverhaul.MedicalUniversityOptions.TryGetValue(prefab.name, out MedicalUniversityOptions MedicalUniversityOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, MedicalUniversityOptions);
            ModifyStats.ModifySchool(prefab, MedicalUniversityOptions);
            ModifyStats.ModifyPollution(prefab, MedicalUniversityOptions);
            ModifyStats.ModifyCityRecoveryFailChange(prefab, MedicalUniversityOptions);
            ModifyStats.ModifyCityHospitalEfficiency(prefab, MedicalUniversityOptions);
        }

        if (WhitesharkCheatOverhaul.LargeHadronColliderOptions.TryGetValue(prefab.name, out var LargeHadronCollideroverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = LargeHadronCollideroverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = LargeHadronCollideroverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = LargeHadronCollideroverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = LargeHadronCollideroverrides.GarbageAccumulation;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var UniversityEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityInterest);
            UniversityEffect.m_Delta = LargeHadronCollideroverrides.CityUniversityInterest;
            
            var OfficeSoftwareDemandEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareDemand);
            OfficeSoftwareDemandEffect.m_Delta = LargeHadronCollideroverrides.CityOfficeSoftwareDemand;
           
            var IndustrialElectronicDemandEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialElectronicsDemand);
            IndustrialElectronicDemandEffect.m_Delta = LargeHadronCollideroverrides.CityIndustrialElectronicDemand;
            
            var OfficeSoftwareEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareEfficiency);
            OfficeSoftwareEfficiencyEffect.m_Delta = LargeHadronCollideroverrides.CityOfficeSoftwareEfficiency;
           
            var IndustrialElectronicEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialElectronicsEfficiency);
            IndustrialElectronicEfficiencyEffect.m_Delta = LargeHadronCollideroverrides.CityIndustrialElectronicEfficiency;

        }

        if (WhitesharkCheatOverhaul.PublicTransportStopsOptions.TryGetValue(prefab.name, out var PublicTransportStopsoverrides))
        {

            var StopComponent = prefab.GetComponent<TransportStop>();
            StopComponent.m_EnterDistance = PublicTransportStopsoverrides.EnterDistance;
            StopComponent.m_ExitDistance = PublicTransportStopsoverrides.ExitDistance;
            StopComponent.m_AccessDistance = PublicTransportStopsoverrides.AccessDistance;
            StopComponent.m_BoardingTime = PublicTransportStopsoverrides.BoardingTime;
            StopComponent.m_ComfortFactor = PublicTransportStopsoverrides.ComfortFactor;
            StopComponent.m_LoadingFactor = PublicTransportStopsoverrides.LoadingFactor;

        }

        if (WhitesharkCheatOverhaul.PublicTransportDepotsOptions.TryGetValue(prefab.name, out var PublicTransportDepotssoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = PublicTransportDepotssoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = PublicTransportDepotssoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = PublicTransportDepotssoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = PublicTransportDepotssoverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = PublicTransportDepotssoverrides.NoisePollution;
            PollutionComponent.m_AirPollution = PublicTransportDepotssoverrides.AirPollution;

            var DepotsComponent = prefab.GetComponent<Game.Prefabs.TransportDepot>();
            DepotsComponent.m_VehicleCapacity = PublicTransportDepotssoverrides.VehicleCapacity;
            DepotsComponent.m_MaintenanceDuration = PublicTransportDepotssoverrides.MaintenanceDuration;

        }

        if (WhitesharkCheatOverhaul.PublicTransportStationsOptions.TryGetValue(prefab.name, out var PublicTransportStationssoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = PublicTransportStationssoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = PublicTransportStationssoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = PublicTransportStationssoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = PublicTransportStationssoverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = PublicTransportStationssoverrides.NoisePollution;

            if (prefab.name == "CargoTrainTerminal01" || prefab.name == "CargoHarbor01")
            {
                var StorageComponent = prefab.GetComponent<Game.Prefabs.StorageLimit>();
                StorageComponent.storageLimit = PublicTransportStationssoverrides.StorageLimit;

                var CargoTransportComponent = prefab.GetComponent<Game.Prefabs.CargoTransportStation>();
                CargoTransportComponent.transports = PublicTransportStationssoverrides.Transports;

            }
            if (prefab.name != "CargoTrainTerminal01" && prefab.name != "CargoHarbor01")
            {
                var TransportComponent = prefab.GetComponent<Game.Prefabs.TransportStation>();
                TransportComponent.m_ComfortFactor = PublicTransportStationssoverrides.ComfortFactor;
            }

        }

        if (WhitesharkCheatOverhaul.AirportOptions.TryGetValue(prefab.name, out var Airportoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Airportoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = Airportoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = Airportoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = Airportoverrides.GarbageAccumulation;

            if (prefab.name == "InternationalAirport01")
            {
                var StorageComponent = prefab.GetComponent<Game.Prefabs.StorageLimit>();
                StorageComponent.storageLimit = Airportoverrides.StorageLimit;

                var UniversityComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
                var UniversityEffect = UniversityComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityInterest);
                UniversityEffect.m_Delta = Airportoverrides.UniversityInterest;

                var OfficeSoftwareComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
                var OfficeSoftwareEffect = OfficeSoftwareComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareDemand);
                OfficeSoftwareEffect.m_Delta = Airportoverrides.OfficeSoftwareDemand;

            }

            var CargoTransportComponent = prefab.GetComponent<Game.Prefabs.CargoTransportStation>();
            CargoTransportComponent.transports = Airportoverrides.Transports;

            var ComfortComponent = prefab.GetComponent<Game.Prefabs.TransportStation>();
            ComfortComponent.m_ComfortFactor = Airportoverrides.ComfortFactor;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var AttractionEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Attractiveness);
            AttractionEffect.m_Delta = Airportoverrides.Attractiveness;

            if (prefab.name == "Airport01")
            {
                var OfficeComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
                var OfficeEfficiencyEffect = OfficeComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeEfficiency);
                OfficeEfficiencyEffect.m_Delta = Airportoverrides.OfficeEfficiency;

            }

        }

        if (WhitesharkCheatOverhaul.SpaceCenterOptions.TryGetValue(prefab.name, out var SpaceCenteroverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = SpaceCenteroverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = SpaceCenteroverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = SpaceCenteroverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = SpaceCenteroverrides.GarbageAccumulation;

            var TransportComponent = prefab.GetComponent<Game.Prefabs.TransportDepot>();
            TransportComponent.m_VehicleCapacity = SpaceCenteroverrides.VehicleCapacity;
            TransportComponent.m_ProductionDuration = SpaceCenteroverrides.ProductionDuration;

            var AttractionComponent = prefab.GetComponent<Game.Prefabs.Attraction>();
            AttractionComponent.m_Attractiveness = SpaceCenteroverrides.Attractiveness;

            var UniversityComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var UniversityEffect = UniversityComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityInterest);
            UniversityEffect.m_Delta = SpaceCenteroverrides.UniversityInterest;

            var OfficeSoftwareComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var OfficeSoftwareEffect = OfficeSoftwareComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeSoftwareDemand);
            OfficeSoftwareEffect.m_Delta = SpaceCenteroverrides.OfficeSoftwareDemand;

            var IndustrialComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var IndustrialEffect = IndustrialComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialElectronicsDemand);
            IndustrialEffect.m_Delta = SpaceCenteroverrides.IndustrialElectronicsDemand;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var AttractionEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Attractiveness);
            AttractionEffect.m_Delta = SpaceCenteroverrides.Attractiveness;

            var LeisureComponent = prefab.GetComponent<Game.Prefabs.LeisureProvider>();
            LeisureComponent.m_Efficiency = SpaceCenteroverrides.LeisureEfficiency;

        }

        if (WhitesharkCheatOverhaul.PostMailboxOptions.TryGetValue(prefab.name, out var PostMailboxoverrides))
        {

            var MailboxComponent = prefab.GetComponent<MailBox>();
            MailboxComponent.m_MailCapacity = PostMailboxoverrides.Mailcapacity;
            MailboxComponent.m_ComfortFactor = PostMailboxoverrides.ComfortFactor;

            var CoverageComponent = prefab.GetComponent<ServiceCoverage>();
            CoverageComponent.m_Range = PostMailboxoverrides.Range;
            CoverageComponent.m_Capacity = PostMailboxoverrides.Capacity;
            CoverageComponent.m_Magnitude = PostMailboxoverrides.Magnitude;

        }

        if (WhitesharkCheatOverhaul.RadioMastOptions.TryGetValue(prefab.name, out var RadioMastoverrides))
        {
            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = RadioMastoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = RadioMastoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = RadioMastoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = RadioMastoverrides.GarbageAccumulation;


            var RadioMastComponent = prefab.GetComponent<Game.Prefabs.TelecomFacility>();
            RadioMastComponent.m_Range = RadioMastoverrides.Range;
            RadioMastComponent.m_NetworkCapacity = RadioMastoverrides.NetworkCapacity;

            if (prefab.name == "RadioMast01")
            {
                var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = RadioMastoverrides.NoisePollution;
            }

        }

        if (WhitesharkCheatOverhaul.DeliveryTruckOptions.TryGetValue(prefab.name, out var DeliveryTruckoverrides))
        {

            var DeliveryTruckComponent = prefab.GetComponent<Game.Prefabs.DeliveryTruck>();
            DeliveryTruckComponent.m_CargoCapacity = DeliveryTruckoverrides.CargoCapacity;
            DeliveryTruckComponent.m_CostToDrive = DeliveryTruckoverrides.CostToDrive;

        }

        if (WhitesharkCheatOverhaul.MaintenanceVehiclesOptions.TryGetValue(prefab.name, out var MaintenanceVehiclesoverrides))
        {

            var MaintenanceVehicleComponent = prefab.GetComponent<Game.Prefabs.MaintenanceVehicle>();
            MaintenanceVehicleComponent.m_MaintenanceCapacity = MaintenanceVehiclesoverrides.MaintenanceCapacity;
            MaintenanceVehicleComponent.m_MaintenanceRate = MaintenanceVehiclesoverrides.MaintenanceRate;

        }

        if (WhitesharkCheatOverhaul.FireEngineOptions.TryGetValue(prefab.name, out var FireEngineoverrides))
        {

            var FireEngineComponent = prefab.GetComponent<Game.Prefabs.FireEngine>();
            FireEngineComponent.m_ExtinguishingCapacity = FireEngineoverrides.ExtinguishingCapacity;
            FireEngineComponent.m_ExtinguishingRate = FireEngineoverrides.ExtinguishingRate;
            FireEngineComponent.m_ExtinguishingSpread = FireEngineoverrides.ExtinguishingSpread;
            FireEngineComponent.m_DestroyedClearDuration = FireEngineoverrides.DestroyedClearDuration;

        }

        if (WhitesharkCheatOverhaul.PoliceCarOptions.TryGetValue(prefab.name, out var PoliceCaroverrides))
        {

            var PoliceCarComponent = prefab.GetComponent<Game.Prefabs.PoliceCar>();
            PoliceCarComponent.m_CriminalCapacity = PoliceCaroverrides.CriminalCapacity;
            PoliceCarComponent.m_CrimeReductionRate = PoliceCaroverrides.CrimeReductionRate;
           
        }

        if (WhitesharkCheatOverhaul.OutsideConnectionOptions.TryGetValue(prefab.name, out var OutsideConnectionoverrides))
        {

            var StorageComponent = prefab.GetComponent<Game.Prefabs.StorageLimit>();
            StorageComponent.storageLimit = OutsideConnectionoverrides.StorageLimit;

            var SchoolComponent = prefab.GetComponent<Game.Prefabs.School>();
            SchoolComponent.m_StudentCapacity = OutsideConnectionoverrides.StudentCapacity;
            SchoolComponent.m_GraduationModifier = OutsideConnectionoverrides.GraduationModifier;

            var HospitalComponent = prefab.GetComponent<Game.Prefabs.Hospital>();
            HospitalComponent.m_AmbulanceCapacity = OutsideConnectionoverrides.AmbulanceCapacity;
            HospitalComponent.m_MedicalHelicopterCapacity = OutsideConnectionoverrides.MedicalHelicopterCapacity;
            HospitalComponent.m_PatientCapacity = OutsideConnectionoverrides.PatientCapacity;
            HospitalComponent.m_TreatmentBonus = OutsideConnectionoverrides.TreatmentBonus;

            var GarbageComponent = prefab.GetComponent<Game.Prefabs.GarbageFacility>();
            GarbageComponent.m_GarbageCapacity = OutsideConnectionoverrides.GarbageCapacity;
            GarbageComponent.m_VehicleCapacity = OutsideConnectionoverrides.GarbageVehicleCapacity;
            GarbageComponent.m_TransportCapacity = OutsideConnectionoverrides.GarbageTransportCapacity;
            GarbageComponent.m_ProcessingSpeed = OutsideConnectionoverrides.GarbageProcessingSpeed;

            var FirestationComponent = prefab.GetComponent<Game.Prefabs.FireStation>();
            FirestationComponent.m_FireEngineCapacity = OutsideConnectionoverrides.FireEngineCapacity;
            FirestationComponent.m_FireHelicopterCapacity = OutsideConnectionoverrides.FireHelicopterCapacity;
            FirestationComponent.m_DisasterResponseCapacity = OutsideConnectionoverrides.DisasterResponseCapacity;
            FirestationComponent.m_VehicleEfficiency = OutsideConnectionoverrides.FireVehicleEfficiency;

            var PoliceStationComponent = prefab.GetComponent<Game.Prefabs.PoliceStation>();
            PoliceStationComponent.m_PatrolCarCapacity = OutsideConnectionoverrides.PolicePatrolCarCapacity;
            PoliceStationComponent.m_PoliceHelicopterCapacity = OutsideConnectionoverrides.PoliceHelicopterCapacity;
            PoliceStationComponent.m_JailCapacity = OutsideConnectionoverrides.JailCapacity;

            var CemeteryComponent = prefab.GetComponent<Game.Prefabs.DeathcareFacility>();
            CemeteryComponent.m_HearseCapacity = OutsideConnectionoverrides.HearseCapacity;
            CemeteryComponent.m_StorageCapacity = OutsideConnectionoverrides.DeathStorageCapacity;
            CemeteryComponent.m_ProcessingRate = OutsideConnectionoverrides.DeathProcessingrate;

            var DepotsComponent = prefab.GetComponent<Game.Prefabs.TransportDepot>();
            DepotsComponent.m_VehicleCapacity = OutsideConnectionoverrides.TaxiVehicleCapacity;
            DepotsComponent.m_MaintenanceDuration = OutsideConnectionoverrides.TaximaintenanceDuration;

            var TrafficspawnerComponent = prefab.GetComponent<Game.Prefabs.TrafficSpawner>();
            TrafficspawnerComponent.m_SpawnRate = OutsideConnectionoverrides.TrafficSpawnerRate;

        }


        

        return true;
    }
}