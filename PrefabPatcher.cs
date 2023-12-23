using Game.Areas;
using Game.Buildings;
using Game.City;
using Game.Prefabs;
using HarmonyLib;
using System.Linq;

namespace WhitesharkCheatOverhaul;

[HarmonyPatch(typeof(PrefabSystem), "AddPrefab")]
public static class PrefabPatcher
{
    [HarmonyPrefix]
    public static bool Prefix(object __instance, PrefabBase prefab)
    {
        if (WhitesharkCheatOverhaul.SchoolOptions.TryGetValue(prefab.name, out var Schooloverrides))
        {

            var costComponent = prefab.GetComponent<ServiceConsumption>();
            costComponent.m_GarbageAccumulation = Schooloverrides.GarbageAccumulation;
            costComponent.m_WaterConsumption = Schooloverrides.Waterconsumption;
            costComponent.m_ElectricityConsumption = Schooloverrides.Electricityconsumption;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_AirPollution = Schooloverrides.AirPollution;
            PollutionComponent.m_GroundPollution = Schooloverrides.GroundPollution;
            PollutionComponent.m_NoisePollution = Schooloverrides.NoisePollution;

        }

        if (WhitesharkCheatOverhaul.PowerplantOptions.TryGetValue(prefab.name, out var Powerplantoverrides))
        {
            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Powerplantoverrides.UpkeepCost;
            ServiceComponent.m_GarbageAccumulation = Powerplantoverrides.GarbageAccumulation;
            ServiceComponent.m_WaterConsumption = Powerplantoverrides.Waterconsumption;

            if (
                prefab.name != "GasPowerPlant01 Advanced Furnace" &&
                prefab.name != "GasPowerPlant01 Exhaust Filter" &&
                prefab.name != "CoalPowerPlant01 Advanced Furnace" &&
                prefab.name != "CoalPowerPlant01 Exhaust Filter"
                )
            {
                var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
                PollutionComponent.m_AirPollution = Powerplantoverrides.AirPollution;
                PollutionComponent.m_GroundPollution = Powerplantoverrides.GroundPollution;
                PollutionComponent.m_NoisePollution = Powerplantoverrides.NoisePollution;
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
                var ProductionComponent = prefab.GetComponent<PowerPlant>();
                ProductionComponent.m_ElectricityProduction = Powerplantoverrides.Production;
            }
            if (
                prefab.name == "GasPowerPlant01 Fuel Storage Extention" || 
                prefab.name == "GasPowerPlant01" || 
                prefab.name == "CoalPowerPlant01" ||
                prefab.name == "CoalPowerPlant01 Coal Storage Yard"
                )
            {
                var StorageComponent = prefab.GetComponent<Game.Prefabs.StorageLimit>();
                StorageComponent.storageLimit = Powerplantoverrides.Storage;
            }

        }
      
        if (WhitesharkCheatOverhaul.WaterpumpOptions.TryGetValue(prefab.name, out var Waterpumpoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Waterpumpoverrides.UpkeepCost;
            ServiceComponent.m_GarbageAccumulation = Waterpumpoverrides.GarbageAccumulation;
            ServiceComponent.m_ElectricityConsumption = Waterpumpoverrides.ElectricityConsumption;

            if (prefab.name != "GroundwaterPumpingStation01 Advanced Filtering System")
            {
                var PollutionComponent = prefab.GetComponent<Pollution>();
                PollutionComponent.m_NoisePollution = Waterpumpoverrides.NoisePollution;
            }
            
            var PumpComponent = prefab.GetComponent<Game.Prefabs.WaterPumpingStation>();
            PumpComponent.m_Capacity = Waterpumpoverrides.Capacity;

            if(prefab.name == "GroundwaterPumpingStation01 Advanced Filtering System")
            {
                var PurificationComponent = prefab.GetComponent<Game.Prefabs.WaterPumpingStation>();
                PurificationComponent.m_Purification = Waterpumpoverrides.Purification;
            }

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

            var TelecomComponent = prefab.GetComponent<Game.Prefabs.TelecomFacility>();
            TelecomComponent.m_Range = Serverfarmoverrides.Range;
            TelecomComponent.m_NetworkCapacity = Serverfarmoverrides.Capacity;

            if (prefab.name == "ServerFarm01" || prefab.name == "SatelliteUplink01")
            {
                var PollutionComponent = prefab.GetComponent<Pollution>();
                PollutionComponent.m_NoisePollution = Serverfarmoverrides.NoisePollution;
            }
            if (prefab.name == "SatelliteUplink01")
            {
                var EnternainmentComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
                var EnternainmentEffect = EnternainmentComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Entertainment);
                EnternainmentEffect.m_Delta = Serverfarmoverrides.CityEntertainment;

                var CityTelecomComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
                var TelecomEffect = CityTelecomComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.TelecomCapacity);
                TelecomEffect.m_Delta = Serverfarmoverrides.CityTelecomCapacity;

                var CityAttractivenessComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
                var CityAttractivenessEffect = CityAttractivenessComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Attractiveness);
                CityAttractivenessEffect.m_Delta = Serverfarmoverrides.CityAttractiveness;

            }

        }

        if (WhitesharkCheatOverhaul.GarbagetruckOptions.TryGetValue(prefab.name, out var Garbagetruckoverrides))
        {

            var GarbageComponent = prefab.GetComponent<Game.Prefabs.GarbageTruck>();
            GarbageComponent.m_GarbageCapacity = Garbagetruckoverrides.Capacity;
            GarbageComponent.m_UnloadRate = Garbagetruckoverrides.Unloadrate;
           
        }

        if (WhitesharkCheatOverhaul.TransportbusOptions.TryGetValue(prefab.name, out var Transportbusoverrides))
        {

            var TransportComponent = prefab.GetComponent<Game.Prefabs.PublicTransport>();
            TransportComponent.m_PassengerCapacity = Transportbusoverrides.Passengercapacity;
            TransportComponent.m_MaintenanceRange = Transportbusoverrides.Maintenancerange;

        }

        if (WhitesharkCheatOverhaul.ParkinghallOptions.TryGetValue(prefab.name, out var Parkinghalloverrides))
        {

            var ParkinghallComponent = prefab.GetComponent<Game.Prefabs.ParkingFacility>();
            ParkinghallComponent.m_GarageMarkerCapacity = Parkinghalloverrides.GarageCapacity;
            ParkinghallComponent.m_ComfortFactor = Parkinghalloverrides.Comfortfactor;

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Parkinghalloverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = Parkinghalloverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = Parkinghalloverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = Parkinghalloverrides.GarbageAccumulation;

            if (prefab.name != "ParkingHall01 Car Wash")
            {
                var PollutionComponent = prefab.GetComponent<Pollution>();
                PollutionComponent.m_NoisePollution = Parkinghalloverrides.Noisepollution;
            }  
        }

        if (WhitesharkCheatOverhaul.CityparkOptions.TryGetValue(prefab.name, out var Cityparkoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Cityparkoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = Cityparkoverrides.ElectricityConsumption;
            ServiceComponent.m_WaterConsumption = Cityparkoverrides.WaterConsumption;
            ServiceComponent.m_GarbageAccumulation = Cityparkoverrides.GarbageAccumulation;

            var CoverageComponent = prefab.GetComponent<ServiceCoverage>();
            CoverageComponent.m_Range = Cityparkoverrides.Range;
            CoverageComponent.m_Capacity = Cityparkoverrides.Capacity;
            CoverageComponent.m_Magnitude = Cityparkoverrides.Magnitude;

            var AttractionComponent = prefab.GetComponent<Game.Prefabs.Attraction>();
            AttractionComponent.m_Attractiveness = Cityparkoverrides.Attractiveness;

            var LeisureComponent = prefab.GetComponent<Game.Prefabs.LeisureProvider>();
            LeisureComponent.m_Efficiency = Cityparkoverrides.Efficiency;


        }

        if (WhitesharkCheatOverhaul.WastewaterOptions.TryGetValue(prefab.name, out var Wastewateroverrides))
        {

            var SewageComponent = prefab.GetComponent<Game.Prefabs.SewageOutlet>();
            SewageComponent.m_Capacity = Wastewateroverrides.Capacity;
            SewageComponent.m_Purification = Wastewateroverrides.Purification;

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Wastewateroverrides.UpkeepCost;
            ServiceComponent.m_GarbageAccumulation = Wastewateroverrides.GarbageAccumulation;
            ServiceComponent.m_ElectricityConsumption = Wastewateroverrides.ElectricityConsumption;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Wastewateroverrides.NoisePollution;
            PollutionComponent.m_AirPollution = Wastewateroverrides.AirPollution;
            PollutionComponent.m_GroundPollution = Wastewateroverrides.GroundPollution;

        }

        if (WhitesharkCheatOverhaul.IncinerationPlantOptions.TryGetValue(prefab.name, out var IncinerationPlantoverrides))
        {

            var GarbageComponent = prefab.GetComponent<Game.Prefabs.GarbageFacility>();
            GarbageComponent.m_GarbageCapacity = IncinerationPlantoverrides.Garbagecapacity;
            GarbageComponent.m_VehicleCapacity = IncinerationPlantoverrides.Vehiclecapacity;
            GarbageComponent.m_TransportCapacity = IncinerationPlantoverrides.Transportcapacity;
            GarbageComponent.m_ProcessingSpeed = IncinerationPlantoverrides.Processingspeed;

            if (prefab.name == "IncinerationPlant01")
            {
                var PowerComponent = prefab.GetComponent<Game.Prefabs.PowerPlant>();
                PowerComponent.m_ElectricityProduction = IncinerationPlantoverrides.Electricityproduction;

                var GarbagePowerComponent = prefab.GetComponent<Game.Prefabs.GarbagePowered>();
                GarbagePowerComponent.m_ProductionPerUnit = IncinerationPlantoverrides.Productionperunit;
                GarbagePowerComponent.m_Capacity = IncinerationPlantoverrides.ProductionCapacity;
               
            }
            
            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = IncinerationPlantoverrides.UpkeepCost;
            ServiceComponent.m_WaterConsumption = IncinerationPlantoverrides.Waterconsumption;
            ServiceComponent.m_ElectricityConsumption = IncinerationPlantoverrides.Electricityconsumption;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = IncinerationPlantoverrides.NoisePollution;
            PollutionComponent.m_AirPollution = IncinerationPlantoverrides.AirPollution;
            PollutionComponent.m_GroundPollution = IncinerationPlantoverrides.GroundPollution;

            if (prefab.name == "HazardousWasteProcessingSite01")
            {
                var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
                var CityEfficencyEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialGroundPollution);
                CityEfficencyEffect.m_Delta = IncinerationPlantoverrides.CityIndustrialGroundPollution;

            }

        }

        if (WhitesharkCheatOverhaul.HealthcareOptions.TryGetValue(prefab.name, out var Healthcareoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Healthcareoverrides.UpkeepCost;
            ServiceComponent.m_WaterConsumption = Healthcareoverrides.Waterconsumption;
            ServiceComponent.m_ElectricityConsumption = Healthcareoverrides.Electricityconsumption;
            ServiceComponent.m_GarbageAccumulation = Healthcareoverrides.GarbageAccumulation;

            var HospitalComponent = prefab.GetComponent<Game.Prefabs.Hospital>();
            HospitalComponent.m_AmbulanceCapacity = Healthcareoverrides.Ambulancecapacity;
            HospitalComponent.m_MedicalHelicopterCapacity = Healthcareoverrides.Helicoptercapacity;
            HospitalComponent.m_PatientCapacity = Healthcareoverrides.Patientcapacity;
            HospitalComponent.m_TreatmentBonus = Healthcareoverrides.Treatmentbonus;
            if (prefab.name == "MedicalClinic01" || prefab.name == "Hospital01")
            {
                var CoverageComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
                CoverageComponent.m_Range = Healthcareoverrides.Range;
                CoverageComponent.m_Capacity = Healthcareoverrides.Capacity;
                CoverageComponent.m_Magnitude = Healthcareoverrides.Magnitude;
            }
        }

        if (WhitesharkCheatOverhaul.PostofficeOptions.TryGetValue(prefab.name, out var Postofficeoverrides))
        {
      
                var ServiceComponent = prefab.GetComponent<Game.Prefabs.ServiceConsumption>();
                ServiceComponent.m_Upkeep = Postofficeoverrides.Upkeep;
                ServiceComponent.m_WaterConsumption = Postofficeoverrides.Waterconsumption;
                ServiceComponent.m_ElectricityConsumption = Postofficeoverrides.Electricityconsumption;
                ServiceComponent.m_GarbageAccumulation = Postofficeoverrides.GarbageAccumulation;

          
                var PostofficeComponent = prefab.GetComponent<Game.Prefabs.PostFacility>();
                PostofficeComponent.m_MailBoxCapacity = Postofficeoverrides.Mailboxcapacity;
                PostofficeComponent.m_PostVanCapacity = Postofficeoverrides.Postvancapacity;
                PostofficeComponent.m_MailStorageCapacity = Postofficeoverrides.Mailstoragecapacity;
                PostofficeComponent.m_PostTruckCapacity = Postofficeoverrides.PostTruckscapacity;
                PostofficeComponent.m_SortingRate = Postofficeoverrides.SortingRate;


                if (prefab.name == "PostOffice01")
                {
                    var CoverageComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
                    CoverageComponent.m_Range = Postofficeoverrides.Range;
                    CoverageComponent.m_Capacity = Postofficeoverrides.Capacity;
                    CoverageComponent.m_Magnitude = Postofficeoverrides.Magnitude;
                }
            
            if (
                prefab.name != "PostSortingFacility01 Automated Sorting"
                )
            {
                var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
                PollutionComponent.m_NoisePollution = Postofficeoverrides.Noisepollution;
            }   
            
        }

        if (WhitesharkCheatOverhaul.CemeteryOptions.TryGetValue(prefab.name, out var Cemeteryoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Cemeteryoverrides.Upkeep;
            ServiceComponent.m_WaterConsumption = Cemeteryoverrides.Waterconsumption;
            ServiceComponent.m_ElectricityConsumption = Cemeteryoverrides.Electricityconsumption;
            ServiceComponent.m_GarbageAccumulation = Cemeteryoverrides.GarbageAccumulation;

            var CemeteryComponent = prefab.GetComponent<Game.Prefabs.DeathcareFacility>();
            CemeteryComponent.m_HearseCapacity = Cemeteryoverrides.Hearsecapacity;
            CemeteryComponent.m_StorageCapacity = Cemeteryoverrides.Storagecapacity;

            var LeisureComponent = prefab.GetComponent<Game.Prefabs.LeisureProvider>();
            LeisureComponent.m_Efficiency = Cemeteryoverrides.Efficiency;

        }

        if (WhitesharkCheatOverhaul.CrematoriumOptions.TryGetValue(prefab.name, out var Crematoriumoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Crematoriumoverrides.Upkeep;
            ServiceComponent.m_WaterConsumption = Crematoriumoverrides.Waterconsumption;
            ServiceComponent.m_ElectricityConsumption = Crematoriumoverrides.Electricityconsumption;
            ServiceComponent.m_GarbageAccumulation = Crematoriumoverrides.GarbageAccumulation;

            var CemeteryComponent = prefab.GetComponent<Game.Prefabs.DeathcareFacility>();
            CemeteryComponent.m_HearseCapacity = Crematoriumoverrides.Hearsecapacity;
            CemeteryComponent.m_StorageCapacity = Crematoriumoverrides.Storagecapacity;
            CemeteryComponent.m_ProcessingRate = Crematoriumoverrides.Processingrate;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = Crematoriumoverrides.Noisepollution;
            PollutionComponent.m_AirPollution = Crematoriumoverrides.Airpollution;
        }

        if (WhitesharkCheatOverhaul.WindturbineOptions.TryGetValue(prefab.name, out var Windturbineoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Windturbineoverrides.Upkeep;
            
            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = Windturbineoverrides.Noisepollution;

            var WindComponent = prefab.GetComponent<Game.Prefabs.WindPowered>();
            WindComponent.m_Production = Windturbineoverrides.Production;
            WindComponent.m_MaximumWind = Windturbineoverrides.Maximumwind;
        }

        if (WhitesharkCheatOverhaul.EmergencybatteryOptions.TryGetValue(prefab.name, out var Emergencybatteryoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Emergencybatteryoverrides.Upkeep;
            ServiceComponent.m_GarbageAccumulation = Emergencybatteryoverrides.GarbageAccumulation;
            ServiceComponent.m_WaterConsumption = Emergencybatteryoverrides.Waterconsumption;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = Emergencybatteryoverrides.Noisepollution;

            var WindComponent = prefab.GetComponent<Game.Prefabs.Battery>();
            WindComponent.m_Capacity = Emergencybatteryoverrides.Capacity;
            WindComponent.m_PowerOutput = Emergencybatteryoverrides.Poweroutput;
        }

        if (WhitesharkCheatOverhaul.GeothermalpowerplantOptions.TryGetValue(prefab.name, out var Geothermalpowerplantoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Geothermalpowerplantoverrides.Upkeep;
            ServiceComponent.m_GarbageAccumulation = Geothermalpowerplantoverrides.GarbageAccumulation;

            var ProductionComponent = prefab.GetComponent<GroundWaterPowered>();
            ProductionComponent.m_Production = Geothermalpowerplantoverrides.Production;
            ProductionComponent.m_MaximumGroundWater = Geothermalpowerplantoverrides.Maximumgroundwater;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_AirPollution = Geothermalpowerplantoverrides.AirPollution;
            PollutionComponent.m_GroundPollution = Geothermalpowerplantoverrides.GroundPollution;
            PollutionComponent.m_NoisePollution = Geothermalpowerplantoverrides.NoisePollution;
                       
        }

        if (WhitesharkCheatOverhaul.SolarpowerstationOptions.TryGetValue(prefab.name, out var Solarpowerstationoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Solarpowerstationoverrides.Upkeep;
            ServiceComponent.m_GarbageAccumulation = Solarpowerstationoverrides.GarbageAccumulation;
            ServiceComponent.m_WaterConsumption = Solarpowerstationoverrides.Waterconsumption;

            var ProductionComponent = prefab.GetComponent<SolarPowered>();
            ProductionComponent.m_Production = Solarpowerstationoverrides.Production;

            var BatteryComponent = prefab.GetComponent<Game.Prefabs.Battery>();
            BatteryComponent.m_PowerOutput = Solarpowerstationoverrides.Poweroutput;
            BatteryComponent.m_Capacity = Solarpowerstationoverrides.Capacity;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = Solarpowerstationoverrides.NoisePollution;

        }

        if (WhitesharkCheatOverhaul.SignatureResidentialbuildingOptions.TryGetValue(prefab.name, out var SignatureResidentialbuildingoverrides))
        {

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
            var WellbeingEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.Wellbeing);
            WellbeingEffect.m_Delta = SignatureResidentialbuildingoverrides.Wellbeing;
            WellbeingEffect.m_Radius = SignatureResidentialbuildingoverrides.Radius;

        }

        if (WhitesharkCheatOverhaul.SignatureCommercialbuildingOptions.TryGetValue(prefab.name, out var SignatureCommercialbuildingoverrides))
        {
            var AttractivenessComponent = prefab.GetComponent<Attraction>();
            AttractivenessComponent.m_Attractiveness = SignatureCommercialbuildingoverrides.Attractiveness;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = SignatureCommercialbuildingoverrides.Noisepollution;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
            var WellbeingEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.Wellbeing);
            WellbeingEffect.m_Delta = SignatureCommercialbuildingoverrides.Wellbeing;
            WellbeingEffect.m_Radius = SignatureCommercialbuildingoverrides.Radius;

            var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var CityimportEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ImportCost);
            var CityAttractionEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Attractiveness);
            CityimportEffect.m_Delta = SignatureCommercialbuildingoverrides.CityImportcost;
            CityAttractionEffect.m_Delta = SignatureCommercialbuildingoverrides.CityAttractiveness;
        }

        if (WhitesharkCheatOverhaul.PostVanOptions.TryGetValue(prefab.name, out var PostVanoverrides))
        {
            var MailComponent = prefab.GetComponent<Game.Prefabs.PostVan>();
            MailComponent.m_MailCapacity = PostVanoverrides.MailCapacity;

            
        }

        if (WhitesharkCheatOverhaul.SignatureOfficebuildingOptions.TryGetValue(prefab.name, out var SignatureOfficebuildingoverrides))
        {
            var AttractivenessComponent = prefab.GetComponent<Attraction>();
            AttractivenessComponent.m_Attractiveness = SignatureOfficebuildingoverrides.Attractiveness;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = SignatureOfficebuildingoverrides.Noisepollution;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
            var WellbeingEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.Wellbeing);
            WellbeingEffect.m_Delta = SignatureOfficebuildingoverrides.Wellbeing;
            WellbeingEffect.m_Radius = SignatureOfficebuildingoverrides.Radius;

            if (prefab.name == "OfficeLowSignature01")
            {
                var CrimeAccumulationEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.CrimeAccumulation);
                CrimeAccumulationEffect.m_Delta = SignatureOfficebuildingoverrides.CrimeAccumulation;
                CrimeAccumulationEffect.m_Radius = SignatureOfficebuildingoverrides.CrimeRadius;
            }


            var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var CityOfficeEfficencyEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeEfficiency);
            var CityUniversityInterestEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityInterest);
            var CityUniversityGraduationEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityGraduation);
            CityOfficeEfficencyEffect.m_Delta = SignatureOfficebuildingoverrides.CityOfficeEfficency;
            CityUniversityInterestEffect.m_Delta = SignatureOfficebuildingoverrides.CityUniversityInterest;
            CityUniversityGraduationEffect.m_Delta = SignatureOfficebuildingoverrides.CityUniversityGraduation;
        }

        if (WhitesharkCheatOverhaul.SignatureMixedbuildingOptions.TryGetValue(prefab.name, out var SignatureMixedbuildingoverrides))
        {
            var AttractivenessComponent = prefab.GetComponent<Attraction>();
            AttractivenessComponent.m_Attractiveness = SignatureMixedbuildingoverrides.Attractiveness;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = SignatureMixedbuildingoverrides.Noisepollution;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
            var WellbeingEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.Wellbeing);
            WellbeingEffect.m_Delta = SignatureMixedbuildingoverrides.Wellbeing;
            WellbeingEffect.m_Radius = SignatureMixedbuildingoverrides.Radius;

            var CityEffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var CityAttractivenessEffect = CityEffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.Attractiveness);
            CityAttractivenessEffect.m_Delta = SignatureMixedbuildingoverrides.CityAttractiveness;
            
        }

        if (WhitesharkCheatOverhaul.FireStationOptions.TryGetValue(prefab.name, out var FireStationverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = FireStationverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = FireStationverrides.ElectricityConsumption;
            ServiceComponent.m_WaterConsumption = FireStationverrides.WaterConsumption;
            ServiceComponent.m_GarbageAccumulation = FireStationverrides.GarbageAccumulation;
                        
            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = FireStationverrides.Noisepollution;

            var FireStationComponent = prefab.GetComponent<Game.Prefabs.FireStation>();
            FireStationComponent.m_FireEngineCapacity = FireStationverrides.FireEngineCapacity;
            FireStationComponent.m_FireHelicopterCapacity = FireStationverrides.FireHelicopterCapacity;
            FireStationComponent.m_VehicleEfficiency = FireStationverrides.VehicleEfficiency;
            FireStationComponent.m_DisasterResponseCapacity = FireStationverrides.DisasterResponseCapacity;

            var CoverageComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
            CoverageComponent.m_Range = FireStationverrides.Range;
            CoverageComponent.m_Capacity = FireStationverrides.Capacity;
            CoverageComponent.m_Magnitude = FireStationverrides.Magnitude;

        }

        if (WhitesharkCheatOverhaul.FireHelicopterDepotOptions.TryGetValue(prefab.name, out var FireHelicopterDepotonverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = FireHelicopterDepotonverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = FireHelicopterDepotonverrides.ElectricityConsumption;
            ServiceComponent.m_WaterConsumption = FireHelicopterDepotonverrides.WaterConsumption;
            ServiceComponent.m_GarbageAccumulation = FireHelicopterDepotonverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = FireHelicopterDepotonverrides.Noisepollution;

            var FireStationComponent = prefab.GetComponent<Game.Prefabs.FireStation>();
            FireStationComponent.m_FireEngineCapacity = FireHelicopterDepotonverrides.FireEngineCapacity;
            FireStationComponent.m_FireHelicopterCapacity = FireHelicopterDepotonverrides.FireHelicopterCapacity;
            FireStationComponent.m_VehicleEfficiency = FireHelicopterDepotonverrides.VehicleEfficiency;
            FireStationComponent.m_DisasterResponseCapacity = FireHelicopterDepotonverrides.DisasterResponseCapacity;

        }

        if (WhitesharkCheatOverhaul.FirewatchTowerOptions.TryGetValue(prefab.name, out var FirewatchToweroverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = FirewatchToweroverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = FirewatchToweroverrides.ElectricityConsumption;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
            var ForestFireResponseEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.ForestFireResponseTime);
            ForestFireResponseEffect.m_Delta = FirewatchToweroverrides.ForestFireResponseTime;
            ForestFireResponseEffect.m_Radius = FirewatchToweroverrides.ForestResponseRadius;
            var ForestFireHazardEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.ForestFireHazard);
            ForestFireHazardEffect.m_Delta = FirewatchToweroverrides.ForestFireHazard;
            ForestFireHazardEffect.m_Radius = FirewatchToweroverrides.ForestFireHazardRadius;

        }

        if (WhitesharkCheatOverhaul.PoliceStationOptions.TryGetValue(prefab.name, out var PoliceStationoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = PoliceStationoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = PoliceStationoverrides.ElectricityConsumption;
            ServiceComponent.m_WaterConsumption = PoliceStationoverrides.WaterConsumption;
            ServiceComponent.m_GarbageAccumulation = PoliceStationoverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = PoliceStationoverrides.Noisepollution;

            var PoliceStationComponent = prefab.GetComponent<Game.Prefabs.PoliceStation>();
            PoliceStationComponent.m_PatrolCarCapacity = PoliceStationoverrides.PatrolCarCapacity;
            PoliceStationComponent.m_PoliceHelicopterCapacity = PoliceStationoverrides.PoliceHelicopterCapacity;
            PoliceStationComponent.m_JailCapacity = PoliceStationoverrides.JailCapacity;


            var CoverageComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
            CoverageComponent.m_Range = PoliceStationoverrides.Range;
            CoverageComponent.m_Capacity = PoliceStationoverrides.Capacity;
            CoverageComponent.m_Magnitude = PoliceStationoverrides.Magnitude;

        }

        if (WhitesharkCheatOverhaul.PrisonOptions.TryGetValue(prefab.name, out var Prisonoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Prisonoverrides.UpkeepCost;
            ServiceComponent.m_ElectricityConsumption = Prisonoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = Prisonoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = Prisonoverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Prisonoverrides.NoisePollution;

            var PrisonComponent = prefab.GetComponent<Game.Prefabs.Prison>();
            PrisonComponent.m_PrisonVanCapacity = Prisonoverrides.PrisonVanCapacity;
            PrisonComponent.m_PrisonerCapacity = Prisonoverrides.PrisonerCapacity;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.LocalEffects>();
            var CrimeEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == LocalModifierType.CrimeAccumulation);
            CrimeEffect.m_Delta = Prisonoverrides.CrimeAccumulation;
            CrimeEffect.m_Radius = Prisonoverrides.CrimeAccumlationRadius;
            
        }

        if (WhitesharkCheatOverhaul.DiseaseControlCenterOptions.TryGetValue(prefab.name, out var DiseaseControlCenteroverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = DiseaseControlCenteroverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = DiseaseControlCenteroverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = DiseaseControlCenteroverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = DiseaseControlCenteroverrides.GarbageAccumulation;

            var HospitalComponent = prefab.GetComponent<Game.Prefabs.Hospital>();
            HospitalComponent.m_AmbulanceCapacity = DiseaseControlCenteroverrides.AmbulanceCapacity;
            HospitalComponent.m_MedicalHelicopterCapacity = DiseaseControlCenteroverrides.MedicalHelicopterCapacity;
            HospitalComponent.m_PatientCapacity = DiseaseControlCenteroverrides.PatientCapacity;
            HospitalComponent.m_TreatmentBonus = DiseaseControlCenteroverrides.TreatmentBonus;


            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var CityDiseaseEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DiseaseProbability);
            CityDiseaseEffect.m_Delta = DiseaseControlCenteroverrides.CityDiseaseprobability;
            var CityPollutionEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.PollutionHealthAffect);
            CityPollutionEffect.m_Delta = DiseaseControlCenteroverrides.CityPollutionhealthAffect;

        }

        if (WhitesharkCheatOverhaul.HeathResearchInstituteOptions.TryGetValue(prefab.name, out var HeathResearchInstituteoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = HeathResearchInstituteoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = HeathResearchInstituteoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = HeathResearchInstituteoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = HeathResearchInstituteoverrides.GarbageAccumulation;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var CityDiseaseEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DiseaseProbability);
            CityDiseaseEffect.m_Delta = HeathResearchInstituteoverrides.CityDiseaseprobability;
            var CityParkEntertainmentEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ParkEntertainment);
            CityParkEntertainmentEffect.m_Delta = HeathResearchInstituteoverrides.CityParkEntertainment;

        }

        if (WhitesharkCheatOverhaul.RadioTelescopeOptions.TryGetValue(prefab.name, out var RadioTelescopeoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = RadioTelescopeoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = RadioTelescopeoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = RadioTelescopeoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = RadioTelescopeoverrides.GarbageAccumulation;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var CityUniversityEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.UniversityGraduation);
            CityUniversityEffect.m_Delta = RadioTelescopeoverrides.CityUniversityGraduation;

        }

        if (WhitesharkCheatOverhaul.GeologicalResearchCenterOptions.TryGetValue(prefab.name, out var GeologicalResearchCenteroverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = GeologicalResearchCenteroverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = GeologicalResearchCenteroverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = GeologicalResearchCenteroverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = GeologicalResearchCenteroverrides.GarbageAccumulation;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = GeologicalResearchCenteroverrides.Noisepollution;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var CityOreAmmountEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OreResourceAmount);
            CityOreAmmountEffect.m_Delta = GeologicalResearchCenteroverrides.CityOreResourceAmmount;
            var CityOilAmmountEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OilResourceAmount);
            CityOilAmmountEffect.m_Delta = GeologicalResearchCenteroverrides.CityOilResourceAmmount;

        }

        if (WhitesharkCheatOverhaul.TechnicalUniversityOptions.TryGetValue(prefab.name, out var TechnicalUniversityoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = TechnicalUniversityoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = TechnicalUniversityoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = TechnicalUniversityoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = TechnicalUniversityoverrides.GarbageAccumulation;

            var SchoolComponent = prefab.GetComponent<Game.Prefabs.School>();
            SchoolComponent.m_StudentCapacity = TechnicalUniversityoverrides.StudentCapacity;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = TechnicalUniversityoverrides.NoisePollution;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var IndustryEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.IndustrialEfficiency);
            IndustryEffect.m_Delta = TechnicalUniversityoverrides.CityIndustrialEfficiency;
            var OfficeEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.OfficeEfficiency);
            OfficeEffect.m_Delta = TechnicalUniversityoverrides.CityOfficeEfficiency;

        }

        if (WhitesharkCheatOverhaul.EarlyDisasterWarningSystemOptions.TryGetValue(prefab.name, out var EarlyDisasterWarningSystemOptionsoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = EarlyDisasterWarningSystemOptionsoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = EarlyDisasterWarningSystemOptionsoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = EarlyDisasterWarningSystemOptionsoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = EarlyDisasterWarningSystemOptionsoverrides.GarbageAccumulation;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var DisasterWarningTimeEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DisasterWarningTime);
            DisasterWarningTimeEffect.m_Delta = EarlyDisasterWarningSystemOptionsoverrides.CityDisasterWarningTime;
            var DisasterDamageRateEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.DisasterDamageRate);
            DisasterDamageRateEffect.m_Delta = EarlyDisasterWarningSystemOptionsoverrides.CityDisasterDamageRate;

        }

        if (WhitesharkCheatOverhaul.WelfareOfficeOptions.TryGetValue(prefab.name, out var WelfareOfficeoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = WelfareOfficeoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = WelfareOfficeoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = WelfareOfficeoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = WelfareOfficeoverrides.GarbageAccumulation;

            var ServiceCoverageComponent = prefab.GetComponent<ServiceCoverage>();
            ServiceCoverageComponent.m_Range = WelfareOfficeoverrides.Range;
            ServiceCoverageComponent.m_Capacity = WelfareOfficeoverrides.Capacity;
            ServiceCoverageComponent.m_Magnitude = WelfareOfficeoverrides.Magnitude;

            var PollutionComponent = prefab.GetComponent<Pollution>();

        }

        if (WhitesharkCheatOverhaul.CityHallOptions.TryGetValue(prefab.name, out var CityHalloverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = CityHalloverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = CityHalloverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = CityHalloverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = CityHalloverrides.GarbageAccumulation;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var LoanEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.LoanInterest);
            LoanEffect.m_Delta = CityHalloverrides.CityLoanIntrest;
            var ImportEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ImportCost);
            ImportEffect.m_Delta = CityHalloverrides.CityImportCost;

        }

        if (WhitesharkCheatOverhaul.LargeEmergencyShelterOptions.TryGetValue(prefab.name, out var LargeEmergencyShelteroverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = LargeEmergencyShelteroverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = LargeEmergencyShelteroverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = LargeEmergencyShelteroverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = LargeEmergencyShelteroverrides.GarbageAccumulation;

            var ShelterComponent = prefab.GetComponent<Game.Prefabs.EmergencyShelter>();
            ShelterComponent.m_ShelterCapacity = LargeEmergencyShelteroverrides.ShelterCapacity;
            ShelterComponent.m_VehicleCapacity = LargeEmergencyShelteroverrides.VehicleCapacity;

            var ServiceCoverageComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
            ServiceCoverageComponent.m_Range = LargeEmergencyShelteroverrides.Range;
            ServiceCoverageComponent.m_Capacity = LargeEmergencyShelteroverrides.Capacity;
            ServiceCoverageComponent.m_Magnitude = LargeEmergencyShelteroverrides.Magnitude;

        }

        if (WhitesharkCheatOverhaul.CentralBankOptions.TryGetValue(prefab.name, out var CentralBankoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = CentralBankoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = CentralBankoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = CentralBankoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = CentralBankoverrides.GarbageAccumulation;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var LoanEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.LoanInterest);
            LoanEffect.m_Delta = CentralBankoverrides.CityLoanIntrest;
            var ImportEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ImportCost);
            ImportEffect.m_Delta = CentralBankoverrides.CityImportCost;
            var ExportEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.ExportCost);
            ExportEffect.m_Delta = CentralBankoverrides.CityExportCost;

        }

        if (WhitesharkCheatOverhaul.MedicalUniversityOptions.TryGetValue(prefab.name, out var MedicalUniversityoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = MedicalUniversityoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = MedicalUniversityoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = MedicalUniversityoverrides.Waterconsumption;
            ServiceComponent.m_GarbageAccumulation = MedicalUniversityoverrides.GarbageAccumulation;

            var SchoolComponent = prefab.GetComponent<Game.Prefabs.School>();
            SchoolComponent.m_StudentCapacity = MedicalUniversityoverrides.StudentCapacity;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = MedicalUniversityoverrides.NoisePollution;

            var EffectsComponent = prefab.GetComponent<Game.Prefabs.CityEffects>();
            var RecoveryEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.RecoveryFailChange);
            RecoveryEffect.m_Delta = MedicalUniversityoverrides.CityRecoverFailChange;
            var HospitalEfficiencyEffect = EffectsComponent.m_Effects.FirstOrDefault(effect => effect.m_Type == CityModifierType.HospitalEfficiency);
            HospitalEfficiencyEffect.m_Delta = MedicalUniversityoverrides.CityHospitalEfficiency;

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