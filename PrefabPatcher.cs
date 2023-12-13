using Game.Audio.Radio;
using Game.Buildings;
using Game.City;
using Game.Modding;
using Game.Prefabs;
using Game.Simulation;
using Game.Vehicles;
using HarmonyLib;
using System.Linq;
using Unity.Mathematics;
using Unity.Transforms;

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
                costComponent.m_Upkeep = Schooloverrides.UpkeepCost;
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

            var TelecomComponent = prefab.GetComponent<Game.Prefabs.TelecomFacility>();
            TelecomComponent.m_Range = Serverfarmoverrides.Range;
            TelecomComponent.m_NetworkCapacity = Serverfarmoverrides.Capacity;

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Serverfarmoverrides.NoisePollution;

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

            var PollutionComponent = prefab.GetComponent<Pollution>();
            PollutionComponent.m_NoisePollution = Parkinghalloverrides.Noisepollution;
        }

        if (WhitesharkCheatOverhaul.CityparkOptions.TryGetValue(prefab.name, out var Cityparkoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Cityparkoverrides.Upkeep;
            ServiceComponent.m_ElectricityConsumption = Cityparkoverrides.Electricityconsumption;
            ServiceComponent.m_WaterConsumption = Cityparkoverrides.Waterconsumption;
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

            var CoverageComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
            CoverageComponent.m_Range = Healthcareoverrides.Range;
            CoverageComponent.m_Capacity = Healthcareoverrides.Capacity;
            CoverageComponent.m_Magnitude = Healthcareoverrides.Magnitude;

        }

        if (WhitesharkCheatOverhaul.PostofficeOptions.TryGetValue(prefab.name, out var Postofficeoverrides))
        {

            var ServiceComponent = prefab.GetComponent<ServiceConsumption>();
            ServiceComponent.m_Upkeep = Postofficeoverrides.Upkeep;
            ServiceComponent.m_WaterConsumption = Postofficeoverrides.Waterconsumption;
            ServiceComponent.m_ElectricityConsumption = Postofficeoverrides.Electricityconsumption;
            ServiceComponent.m_GarbageAccumulation = Postofficeoverrides.GarbageAccumulation;

            var PostofficeComponent = prefab.GetComponent<Game.Prefabs.PostFacility>();
            PostofficeComponent.m_MailBoxCapacity = Postofficeoverrides.Mailboxcapacity;
            PostofficeComponent.m_PostVanCapacity = Postofficeoverrides.Postvancapacity;
            PostofficeComponent.m_MailStorageCapacity = Postofficeoverrides.Mailstoragecapacity;
            PostofficeComponent.m_PostTruckCapacity = Postofficeoverrides.PostTruckscapacity;


            var CoverageComponent = prefab.GetComponent<Game.Prefabs.ServiceCoverage>();
            CoverageComponent.m_Range = Postofficeoverrides.Range;
            CoverageComponent.m_Capacity = Postofficeoverrides.Capacity;
            CoverageComponent.m_Magnitude = Postofficeoverrides.Magnitude;

            var PollutionComponent = prefab.GetComponent<Game.Prefabs.Pollution>();
            PollutionComponent.m_NoisePollution = Postofficeoverrides.Noisepollution;
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
        return true;
    }
}