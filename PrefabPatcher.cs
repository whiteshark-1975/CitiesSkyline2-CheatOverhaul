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
            if (prefab.name == "IncinerationPlant01" || prefab.name == "IncinerationPlant01 Extra Incinerator Furnace")
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
        if (WhitesharkCheatOverhaul.FireFightingHelicopterDepotOptions.TryGetValue(prefab.name, out FireFightingHelicopterDepotOptions FireFightingHelicopterDepotOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, FireFightingHelicopterDepotOptions);
            ModifyStats.ModifyPollution(prefab, FireFightingHelicopterDepotOptions);
            ModifyStats.ModifyFireStation(prefab, FireFightingHelicopterDepotOptions);            
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
        if (WhitesharkCheatOverhaul.LargeHadronColliderOptions.TryGetValue(prefab.name, out LargeHadronColliderOptions LargeHadronColliderOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, LargeHadronColliderOptions);
            ModifyStats.ModifyCityUniversityInterest(prefab, LargeHadronColliderOptions);
            ModifyStats.ModifyCityOfficeSoftwareDemand(prefab, LargeHadronColliderOptions);
            ModifyStats.ModifyCityOfficeSoftwareEfficiency(prefab, LargeHadronColliderOptions);
            ModifyStats.ModifyCityIndustrialElectronicsDemand(prefab, LargeHadronColliderOptions);
            ModifyStats.ModifyCityIndustrialElectronicsEfficiency(prefab, LargeHadronColliderOptions);
        }
        if (WhitesharkCheatOverhaul.PublicTransportStopsOptions.TryGetValue(prefab.name, out PublicTransportStopsOptions PublicTransportStopsOptions))
        {
            ModifyStats.ModifyPublicTransportStops(prefab, PublicTransportStopsOptions);
        }
        if (WhitesharkCheatOverhaul.PublicTransportDepotsOptions.TryGetValue(prefab.name, out PublicTransportDepotsOptions PublicTransportDepotsOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, PublicTransportDepotsOptions);
            ModifyStats.ModifyPollution(prefab, PublicTransportDepotsOptions);
            ModifyStats.ModifyPublicTransportDepot(prefab, PublicTransportDepotsOptions);
        }
        if (WhitesharkCheatOverhaul.PublicTransportStationsOptions.TryGetValue(prefab.name, out PublicTransportStationsOptions PublicTransportStationsOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, PublicTransportStationsOptions);
            ModifyStats.ModifyPollution(prefab, PublicTransportStationsOptions);     
            if (prefab.name == "CargoTrainTerminal01" || prefab.name == "CargoHarbor01")
            {
                ModifyStats.ModifyStorageLimit(prefab, PublicTransportStationsOptions);

                ModifyStats.ModifyCargoTransportStation(prefab, PublicTransportStationsOptions);
            }
            if (prefab.name != "CargoTrainTerminal01" && prefab.name != "CargoHarbor01")
            {
                ModifyStats.ModifyPublicTransportStation(prefab, PublicTransportStationsOptions);                
            }
        }
        if (WhitesharkCheatOverhaul.AirportOptions.TryGetValue(prefab.name, out AirportOptions AirportOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, AirportOptions);  
            if (prefab.name == "InternationalAirport01")
            {
                ModifyStats.ModifyStorageLimit(prefab, AirportOptions);
                ModifyStats.ModifyCityUniversityInterest(prefab, AirportOptions);
                ModifyStats.ModifyCityOfficeSoftwareDemand(prefab, AirportOptions);
            }
            ModifyStats.ModifyCargoTransportStation(prefab, AirportOptions);
            ModifyStats.ModifyPublicTransportStation(prefab, AirportOptions);
            ModifyStats.ModifyCityAttractiveness(prefab, AirportOptions);    
            if (prefab.name == "Airport01")
            {
                ModifyStats.ModifyCityOfficeEfficiency(prefab, AirportOptions);
            }
        }
        if (WhitesharkCheatOverhaul.SpaceCenterOptions.TryGetValue(prefab.name, out SpaceCenterOptions SpaceCenterOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, SpaceCenterOptions);
            ModifyStats.ModifyPublicTransportDepot(prefab, SpaceCenterOptions);
            ModifyStats.ModifyAttraction(prefab, SpaceCenterOptions);
            ModifyStats.ModifyCityUniversityInterest(prefab, SpaceCenterOptions);
            ModifyStats.ModifyCityOfficeSoftwareDemand(prefab, SpaceCenterOptions);
            ModifyStats.ModifyCityIndustrialElectronicsDemand(prefab, SpaceCenterOptions);
            ModifyStats.ModifyCityAttractiveness(prefab, SpaceCenterOptions);
            ModifyStats.ModifyLeisureProvider(prefab, SpaceCenterOptions);
        }
        if (WhitesharkCheatOverhaul.PostMailboxOptions.TryGetValue(prefab.name, out PostMailboxOptions PostMailboxOptions))
        {
            ModifyStats.ModifyMailbox(prefab, PostMailboxOptions);
            ModifyStats.ModifyServiceCoverage(prefab, PostMailboxOptions);
        }
        if (WhitesharkCheatOverhaul.RadioMastOptions.TryGetValue(prefab.name, out var RadioMastOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, RadioMastOptions);
            ModifyStats.ModifyTelecomFacility(prefab, RadioMastOptions);   
            if (prefab.name == "RadioMast01")
            {
                ModifyStats.ModifyPollution(prefab, RadioMastOptions);
            }
        }
        if (WhitesharkCheatOverhaul.DeliveryTruckOptions.TryGetValue(prefab.name, out DeliveryTruckOptions DeliveryTruckOptions))
        {
            ModifyStats.ModifyDeliveryTruck(prefab, DeliveryTruckOptions);
        }
        if (WhitesharkCheatOverhaul.MaintenanceVehiclesOptions.TryGetValue(prefab.name, out MaintenanceVehiclesOptions MaintenanceVehiclesOptions))
        {
            ModifyStats.ModifyMaintenanceVehicle(prefab, MaintenanceVehiclesOptions);
        }
        if (WhitesharkCheatOverhaul.FireEngineOptions.TryGetValue(prefab.name, out FireEngineOptions FireEngineOptions))
        {
            ModifyStats.ModifyFireEngine(prefab, FireEngineOptions);
        }
        if (WhitesharkCheatOverhaul.PoliceCarOptions.TryGetValue(prefab.name, out PoliceCarOptions PoliceCarOptions))
        {
            ModifyStats.ModifyPoliceCar(prefab, PoliceCarOptions);            
        }
        if (WhitesharkCheatOverhaul.OutsideConnectionOptions.TryGetValue(prefab.name, out OutsideConnectionOptions OutsideConnectionOptions))
        {
            ModifyStats.ModifyStorageLimit(prefab, OutsideConnectionOptions);
            ModifyStats.ModifySchool(prefab, OutsideConnectionOptions);
            ModifyStats.ModifyHospital(prefab, OutsideConnectionOptions);
            ModifyStats.ModifyGarbageFacility(prefab, OutsideConnectionOptions);
            ModifyStats.ModifyFireStation(prefab, OutsideConnectionOptions);
            ModifyStats.ModifyPoliceStation(prefab, OutsideConnectionOptions);
            ModifyStats.ModifyIDeathcareFacility(prefab, OutsideConnectionOptions);
            ModifyStats.ModifyPublicTransportDepot(prefab, OutsideConnectionOptions);
            ModifyStats.ModifyTrafficSpawner(prefab, OutsideConnectionOptions);
        }
        if (WhitesharkCheatOverhaul.MaintenanceDepotOptions.TryGetValue(prefab.name, out MaintenanceDepotOptions MaintenanceDepotOptions))
        {
            ModifyStats.ModifyServiceConsumption(prefab, MaintenanceDepotOptions);
            ModifyStats.ModifyMaintenanceDepot(prefab, MaintenanceDepotOptions);
            ModifyStats.ModifyPollution(prefab, MaintenanceDepotOptions);
        }

        return true;
    }
}