using Game.Buildings;
using Game.Simulation;
using Game.UI.InGame;
using Game.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine.InputSystem.Utilities;
using static Colossal.AssetPipeline.Importers.DidimoImporter.DidimoData;

namespace WhitesharkCheatOverhaul;

public class WhitesharkCheatOverhaulOptions
{
    public static WhitesharkCheatOverhaulOptions Default => new WhitesharkCheatOverhaulOptions
    {
        School_Options = new List<SchoolOptions>
        {
            new SchoolOptions
            {
                Name = "ElementarySchool01",
                UpkeepCost = 2500,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 7500,
                GarbageAccumulation = 1900,
                Waterconsumption = 1500,
                Electricityconsumption = 1000
            },
            new SchoolOptions
            {
                Name = "HighSchool01",
                UpkeepCost = 45000,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 7500,
                GarbageAccumulation = 1300,
                Waterconsumption = 1500,
                Electricityconsumption = 1500

            },
            new SchoolOptions
            {
                Name = "College01",
                UpkeepCost = 150000,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 10000,
                GarbageAccumulation = 2400,
                Waterconsumption = 1500,
                Electricityconsumption = 2000

            },
            new SchoolOptions
            {
                Name = "University01",
                UpkeepCost = 200000,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 10000,
                GarbageAccumulation = 2400,
                Waterconsumption = 3000,
                Electricityconsumption = 3000

            }
        },

        Powerplant_Options = new List<PowerplantOptions>
        {
            new PowerplantOptions
            {
                Name = "GasPowerPlant01",
                UpkeepCost = 600000,
                Waterconsumption = 48000,
                GarbageAccumulation = 30000,
                AirPollution = 10000,
                GroundPollution = 10000,
                NoisePollution = 10000,
                Production = 2500000
            },
            new PowerplantOptions
            {
                Name = "CoalPowerPlant01",
                UpkeepCost = 15000,
                Waterconsumption = 60000,
                GarbageAccumulation = 50000,
                AirPollution = 100000,
                GroundPollution = 100000,
                NoisePollution = 100000,
                Production = 3000000
            },
            new PowerplantOptions
            {
                Name = "NuclearPowerPlant01",
                UpkeepCost = 1000000,
                Waterconsumption = 400000,
                GarbageAccumulation = 40000,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 150000,
                Production = 7500000
            },
            new PowerplantOptions
            {
                Name = "SmallCoalPowerPlant01",
                UpkeepCost = 10000,
                Waterconsumption = 15000,
                GarbageAccumulation = 25000,
                AirPollution = 30000,
                GroundPollution = 30000,
                NoisePollution = 30000,
                Production = 200000
            }
        },

        Waterpump_Options = new List<WaterpumpOptions>
        {
            new WaterpumpOptions
            {
                Name = "WaterPumpingStation01",
                UpkeepCost = 10000,
                Capacity = 100000,
                GarbageAccumulation = 12500,
                ElectricityConsumption = 3000,
                NoisePollution =5000
            },
            new WaterpumpOptions
            {
                Name = "GroundwaterPumpingStation01",
                UpkeepCost = 20000,
                Capacity = 75000,
                GarbageAccumulation = 10000,
                ElectricityConsumption = 3000,
                NoisePollution =5000

            },
            new WaterpumpOptions
            {
                Name = "DesalinationPlant01",
                UpkeepCost = 95000,
                Capacity = 1000000,
                GarbageAccumulation = 62500,
                ElectricityConsumption = 3000,
                NoisePollution = 25000

            },
            new WaterpumpOptions
            {
                Name = "WaterTower01",
                UpkeepCost = 30000,
                Capacity = 30000,
                GarbageAccumulation = 0,
                ElectricityConsumption = 0,
                NoisePollution = 2500

            }
        },

        Transformerstation_Options = new List<TransformerstationOptions>
        {
            new TransformerstationOptions
            {
                Name = "TransformerStation01",
                UpkeepCost = 6000,
                GarbageAccumulation = 100,
                NoisePollution = 5000
            }
        },

        Serverfarm_Options = new List<ServerfarmOptions>
        {
            new ServerfarmOptions
            {
                Name = "ServerFarm01",
                UpkeepCost = 50000,
                Electricityconsumption = 20000,
                Waterconsumption = 10000,
                GarbageAccumulation = 3000,
                Range = 2500,
                Capacity = 20000,
                NoisePollution = 20000
            }
        },

        Garbagetruck_Options = new List<GarbagetruckOptions>
        {
            new GarbagetruckOptions
            {
                Name = "GarbageTruck01",
                Capacity = 20000,
                Unloadrate = 4000
            }
        },

        Transportbus_Options = new List<TransportbusOptions>
        {
            new TransportbusOptions
            {
                Name = "Bus01",
                Passengercapacity = 80,
                Maintenancerange = 200
            },
            new TransportbusOptions
            {
                Name = "Bus02",
                Passengercapacity = 80,
                Maintenancerange = 250
            },
            new TransportbusOptions
            {
                Name = "Bus03",
                Passengercapacity = 80,
                Maintenancerange = 200
            },
            new TransportbusOptions
            {
                Name = "TrainPassengerCar01",
                Passengercapacity = 120,
                Maintenancerange = 1000
            },
            new TransportbusOptions
            {
                Name = "TrainPassengerEngine01",
                Passengercapacity = 120,
                Maintenancerange = 1000
            },
            new TransportbusOptions
            {
                Name = "SubwayCar01",
                Passengercapacity = 150,
                Maintenancerange = 850
            },
            new TransportbusOptions
            {
                Name = "SubwayEngine01",
                Passengercapacity = 120,
                Maintenancerange = 850
            },
            new TransportbusOptions
            {
                Name = "TramCar01",
                Passengercapacity = 80,
                Maintenancerange = 600
            },
            new TransportbusOptions
            {
                Name = "TramEngine01",
                Passengercapacity = 80,
                Maintenancerange = 600
            }
        },

        Parkinghall_Options = new List<ParkinghallOptions>
        {
            new ParkinghallOptions
            {
                Name = "ParkingHall01",
                Upkeep = 30000,
                GarageCapacity = 0,
                Comfortfactor = 0.6f,
                Electricityconsumption = 2400,
                Waterconsumption = 2000,
                GarbageAccumulation = 1600,
                Noisepollution = 2500
            },
            new ParkinghallOptions
            {
                Name = "ParkingHall02",
                Upkeep = 40000,
                GarageCapacity = 100,
                Comfortfactor = 0.65f,
                Electricityconsumption = 3000,
                Waterconsumption = 2000,
                GarbageAccumulation = 2000,
                Noisepollution = 2500
            }
        },

        Citypark_Options = new List<CityparkOptions>
        {
            new CityparkOptions
            {
                Name = "CityPark01",
                Upkeep = 2000,
                Range = 2500,
                Capacity = 800,
                Magnitude = 10,
                Attractiveness = 1,
                Efficiency = 1,
                Electricityconsumption = 500,
                Waterconsumption = 0,
                GarbageAccumulation = 100
                
},
            new CityparkOptions
            {
                Name = "CityPark02",
                Upkeep = 4000,
                Range = 4000,
                Capacity = 1200,
                Magnitude = 10,
                Attractiveness = 5,
                Efficiency = 2,
                Electricityconsumption = 750,
                Waterconsumption = 500,
                GarbageAccumulation = 200
            },
            new CityparkOptions
            {
                Name = "CityPark03",
                Upkeep = 8500,
                Range = 3000,
                Capacity = 1600,
                Magnitude = 14,
                Attractiveness = 10,
                Efficiency = 3,
                Electricityconsumption = 10000,
                Waterconsumption = 750,
                GarbageAccumulation = 300

},
            new CityparkOptions
            {
                Name = "CityPark04",
                Upkeep = 12500,
                Range = 4000,
                Capacity = 2000,
                Magnitude = 14,
                Attractiveness = 15,
                Efficiency = 5,
                Electricityconsumption = 1500,
                Waterconsumption = 1000,
                GarbageAccumulation = 400
            }
        },

        Wastewater_Options = new List<WastewaterOptions>
        {
            new WastewaterOptions
            {
                Name = "WastewaterTreatmentPlant01",
                UpkeepCost = 120000,
                Capacity = 400000,
                Purification = 0.5f,
                GarbageAccumulation = 50000,
                GroundPollution = 7500,
                AirPollution = 7500,
                NoisePollution = 15000,
                ElectricityConsumption = 3000
            },
            new WastewaterOptions
            {
                Name = "SewageOutlet01",
                UpkeepCost = 20000,
                Capacity = 100000,
                Purification = 0,
                GarbageAccumulation = 0,
                GroundPollution = 0,
                AirPollution = 5000,
                NoisePollution = 5000,
                ElectricityConsumption = 0
            }
        },

        IncinerationPlant_Options = new List<IncinerationPlantOptions>
        {
            new IncinerationPlantOptions
            {
                Name = "IncinerationPlant01",
                Garbagecapacity = 3000000,
                Vehiclecapacity = 50,
                Transportcapacity = 1,
                Processingspeed = 3000000,
                Electricityproduction = 0,
                Productionperunit = 7.5f,
                ProductionCapacity = 400000,
                UpkeepCost = 210000,
                Waterconsumption = 25000,
                GroundPollution = 40000,
                AirPollution = 40000,
                NoisePollution = 40000                

            },

            new IncinerationPlantOptions
            {
                Name = "Landfill01",
                Garbagecapacity = 20000,
                Vehiclecapacity = 20,
                Transportcapacity = 1,
                Processingspeed = 100000,
                UpkeepCost = 30000,
                Electricityconsumption = 1000,
                Waterconsumption = 2500,
                GroundPollution = 20000,
                AirPollution = 20000,
                NoisePollution = 40000
            },

            new IncinerationPlantOptions
            {
                Name = "RecyclingCenter01",
                Garbagecapacity = 1500000,
                Vehiclecapacity = 15,
                Transportcapacity = 1,
                Processingspeed = 1,
                UpkeepCost = 1500000,
                Electricityconsumption = 2500,
                Waterconsumption = 10000,
                GroundPollution = 10000,
                AirPollution = 5000,
                NoisePollution = 15000
            },

            new IncinerationPlantOptions
            {
                Name = "HazardousWasteProcessingSite01",
                Garbagecapacity = 50000000,
                Vehiclecapacity = 250,
                Transportcapacity = 1,
                Processingspeed = 50000000,
                UpkeepCost = 450000,
                Electricityconsumption = 15000,
                Waterconsumption = 25000,
                CityIndustrialGroundPollution = -0.15f,
                GroundPollution = 50000,
                AirPollution = 50000,
                NoisePollution = 50000
            }
        },
    

        Healthcare_Options = new List<HealthcareOptions>
        {
            new HealthcareOptions
            {
                Name = "MedicalClinic01",
                UpkeepCost = 40000,
                Waterconsumption = 1000,
                Electricityconsumption = 2500,
                GarbageAccumulation = 1900,
                NoisePollution = 0,
                Ambulancecapacity = 5,
                Helicoptercapacity = 0,
                Patientcapacity = 100,
                Treatmentbonus = 15,
                Capacity = 15000,
                Range = 5000,
                Magnitude = 5
            },
            new HealthcareOptions
            {
                Name = "Hospital01",
                UpkeepCost = 450000,
                Waterconsumption = 5000,
                Electricityconsumption = 10000,
                GarbageAccumulation = 9400,
                NoisePollution = 0,
                Ambulancecapacity = 30,
                Helicoptercapacity = 0,
                Patientcapacity = 500,
                Treatmentbonus = 30,
                Capacity = 50000,
                Range = 7500,
                Magnitude = 10
            }
        },
        
        Postoffice_Options = new List<PostofficeOptions>
        {
            new PostofficeOptions
            {
                Name = "PostOffice01",
                Upkeep = 45000,
                Waterconsumption = 1000,
                Electricityconsumption = 500,
                GarbageAccumulation = 1900,
                Noisepollution = 5000,
                Mailboxcapacity = 500,
                Postvancapacity = 20,
                PostTruckscapacity = 0,
                Mailstoragecapacity = 100000,
                Capacity = 15000,
                Range = 2000,
                Magnitude = 2
            }
        },

        Cemetery_Options = new List<CemeteryOptions>
        {
            new CemeteryOptions
            {
                Name = "Cemetery01",
                Upkeep = 55000,
                Waterconsumption = 2000,
                Electricityconsumption = 800,
                GarbageAccumulation = 700,
                Hearsecapacity = 15,
                Storagecapacity = 5000,
                Efficiency = 3
            }
        },

        Crematorium_Options = new List<CrematoriumOptions>
        {
            new CrematoriumOptions
            {
                Name = "Crematorium01",
                Upkeep = 45000,
                Waterconsumption = 500,
                Electricityconsumption = 1300,
                GarbageAccumulation = 6300,
                Hearsecapacity = 10,
                Storagecapacity = 20,
                Processingrate = 100,
                Airpollution = 2500,
                Noisepollution = 5000
            }
        },

        Windturbine_Options = new List<WindturbineOptions>
        {
            new WindturbineOptions
            {
                Name = "WindTurbine01",
                Upkeep = 15000,
                Production = 50000,
                Maximumwind = 0.4f,
                Noisepollution = 20000
            }
        },

        Emergencybattery_Options = new List<EmergencybatteryOptions>
        {
            new EmergencybatteryOptions
            {
                Name = "EmergencyBatteryStation01",
                Upkeep = 50000,
                Capacity = 5000000,
                Poweroutput = 2000000,
                Noisepollution = 10000,
                GarbageAccumulation = 15000,
                Waterconsumption = 5000
            }
        },

        Geothermalpowerplant_Options = new List<GeothermalpowerplantOptions>
        {
            new GeothermalpowerplantOptions
            {
                Name = "GeothermalPowerPlant01",
                Upkeep = 300000,
                Production = 1500000,
                Maximumgroundwater = 4000,
                GarbageAccumulation = 25000,
                AirPollution = 15000,
                GroundPollution = 15000,
                NoisePollution = 20000
            }
        },

        Solarpowerstation_Options = new List<SolarpowerstationOptions>
        {
            new SolarpowerstationOptions
            {
                Name = "SolarPowerStation01",
                Upkeep = 300000,
                Waterconsumption = 36000,
                GarbageAccumulation = 30000,
                Production = 2000000,
                Poweroutput = 150000,
                Capacity = 500000,
                NoisePollution = 50000
            }
        },

        SignatureResidentialbuilding_Options = new List<SignatureResidentialbuildingOptions>
        {
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialLowSignature01",
                Wellbeing = 2,
                Radius = 500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialLowSignature02",
                Wellbeing = 4,
                Radius = 1000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialLowSignature03",
                Wellbeing = 6,
                Radius = 1500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialLowSignature01",
                Wellbeing = 2,
                Radius = 500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialLowSignature02",
                Wellbeing = 4,
                Radius = 1000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialLowSignature03",
                Wellbeing = 6,
                Radius = 1500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialMediumSignature01",
                Wellbeing = 4,
                Radius = 1000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialMediumSignature02",
                Wellbeing = 8,
                Radius = 2000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialMediumSignature03",
                Wellbeing = 10,
                Radius = 2500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialMediumSignature01",
                Wellbeing = 4,
                Radius = 1000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialMediumSignature02",
                Wellbeing = 8,
                Radius = 2000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialMediumSignature03",
                Wellbeing = 10,
                Radius = 2500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialHighSignature01",
                Wellbeing = 6,
                Radius = 1500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialHighSignature02",
                Wellbeing = 10,
                Radius = 2500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialHighSignature03",
                Wellbeing = 12,
                Radius = 3000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialHighSignature01",
                Wellbeing = 6,
                Radius = 1500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialHighSignature02",
                Wellbeing = 10,
                Radius = 2500
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialHighSignature03",
                Wellbeing = 12,
                Radius = 3000
            }

        },

        SignatureCommercialbuilding_Options = new List<SignatureCommercialbuildingOptions>
        {
            new SignatureCommercialbuildingOptions
            {
                Name = "EU_CommercialLowSignature01",
                Wellbeing = 3,
                Radius = 500,
                CityAttractiveness = 0.005f,
                CityImportcost = -0.005f,
                Noisepollution = 1000,
                Attractiveness = 5
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "EU_CommercialLowSignature02",
                Wellbeing = 3,
                Radius = 1000,
                CityAttractiveness = 0.005f,
                CityImportcost = -0.005f,
                Noisepollution = 4000,
                Attractiveness = 10
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "EU_CommercialLowSignature03",
                Wellbeing = 3,
                Radius = 1500,
                CityAttractiveness = 0.005f,
                CityImportcost = -0.005f,
                Noisepollution = 7000,
                Attractiveness = 15
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "NA_CommercialLowSignature01",
                Wellbeing = 3,
                Radius = 500,
                CityAttractiveness = 0.005f,
                CityImportcost = -0.005f,
                Noisepollution = 1000,
                Attractiveness = 5
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "NA_CommercialLowSignature02",
                Wellbeing = 3,
                Radius = 1000,
                CityAttractiveness = 0.005f,
                CityImportcost = -0.005f,
                Noisepollution = 2000,
                Attractiveness = 10
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "NA_CommercialLowSignature03",
                Wellbeing = 3,
                Radius = 1500,
                CityAttractiveness = 0.005f,
                CityImportcost = -0.005f,
                Noisepollution = 4000,
                Attractiveness = 15
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "EU_CommercialHighSignature01",
                Wellbeing = 5,
                Radius = 1000,
                CityAttractiveness = 0.010f,
                CityImportcost = -0.010f,
                Noisepollution = 3000,
                Attractiveness = 10
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "EU_CommercialHighSignature02",
                Wellbeing = 5,
                Radius = 1500,
                CityAttractiveness = 0.010f,
                CityImportcost = -0.010f,
                Noisepollution = 4000,
                Attractiveness = 20
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "EU_CommercialHighSignature03",
                Wellbeing = 5,
                Radius = 2000,
                CityAttractiveness = 0.010f,
                CityImportcost = -0.010f,
                Noisepollution = 5000,
                Attractiveness = 30
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "NA_CommercialHighSignature01",
                Wellbeing = 5,
                Radius = 1000,
                CityAttractiveness = 0.010f,
                CityImportcost = -0.010f,
                Noisepollution = 3000,
                Attractiveness = 10
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "NA_CommercialHighSignature02",
                Wellbeing = 5,
                Radius = 1500,
                CityAttractiveness = 0.010f,
                CityImportcost = -0.010f,
                Noisepollution = 4000,
                Attractiveness = 20
            },
            new SignatureCommercialbuildingOptions
            {
                Name = "NA_CommercialHighSignature03",
                Wellbeing = 5,
                Radius = 2000,
                CityAttractiveness = 0.010f,
                CityImportcost = -0.010f,
                Noisepollution = 5000,
                Attractiveness = 30
            }
        },

        PostVan_Options = new List<PostVanOptions>
        {
            new PostVanOptions
            {
                Name = "EU_PostVan01",
                MailCapacity = 2000
                
            },
            new PostVanOptions
            {
                Name = "NA_PostVan01",
                MailCapacity = 2000

            }
        },

        SignatureOfficebuilding_Options = new List<SignatureOfficebuildingOptions>
        {
            new SignatureOfficebuildingOptions
            {
                Name = "OfficeHighSignature01",
                Attractiveness = 10,
                Wellbeing = 5,
                Radius = 1000,
                CityOfficeEfficency = 0.020f,
                CityUniversityInterest = 0.050f,
                CityUniversityGraduation = 0.010f,
                Noisepollution = 3000

            },
            new SignatureOfficebuildingOptions
            {
                Name = "OfficeHighSignature02",
                Attractiveness = 20,
                Wellbeing = 5,
                Radius = 1500,
                CityOfficeEfficency = 0.020f,
                CityUniversityInterest = 0.050f,
                CityUniversityGraduation = 0.010f,
                Noisepollution = 1000

            },
            new SignatureOfficebuildingOptions
            {
                Name = "OfficeHighSignature03",
                Attractiveness = 30,
                Wellbeing = 5,
                Radius = 2000,
                CityOfficeEfficency = 0.020f,
                CityUniversityInterest = 0.050f,
                CityUniversityGraduation = 0.010f,
                Noisepollution = 5000

            },
            new SignatureOfficebuildingOptions
            {
                Name = "OfficeLowSignature01",
                Attractiveness = 5,
                Wellbeing = 5,
                Radius = 500,
                CrimeAccumulation = -2f,
                CrimeRadius = 500,
                CityOfficeEfficency = 0.010f,
                CityUniversityInterest = 0.050f,
                CityUniversityGraduation = 0.010f,
                Noisepollution = 3000

            },
            new SignatureOfficebuildingOptions
            {
                Name = "OfficeLowSignature02",
                Attractiveness = 10,
                Wellbeing = 5,
                Radius = 1000,
                CityOfficeEfficency = 0.010f,
                CityUniversityInterest = 0.050f,
                CityUniversityGraduation = 0.010f,
                Noisepollution = 2000

            },
            new SignatureOfficebuildingOptions
            {
                Name = "OfficeLowSignature03",
                Attractiveness = 15,
                Wellbeing = 5,
                Radius = 1500,
                CityOfficeEfficency = 0.010f,
                CityUniversityInterest = 0.050f,
                CityUniversityGraduation = 0.010f,
                Noisepollution = 3000

            }

        },

        SignatureMixedbuilding_Options = new List<SignatureMixedbuildingOptions>
        {
            new SignatureMixedbuildingOptions
            {
                Name = "EU_MixedSignature01",
                Attractiveness = 5,
                Wellbeing = 4,
                Radius = 750,
                CityAttractiveness = 0.010f,
                Noisepollution = 1500

            },
            new SignatureMixedbuildingOptions
            {
                Name = "EU_MixedSignature02",
                Attractiveness = 10,
                Wellbeing = 8,
                Radius = 1250,
                CityAttractiveness = 0.010f,
                Noisepollution = 1500

            },
            new SignatureMixedbuildingOptions
            {
                Name = "EU_MixedSignature03",
                Attractiveness = 15,
                Wellbeing = 10,
                Radius = 2000,
                CityAttractiveness = 0.010f,
                Noisepollution = 1500

            },
            new SignatureMixedbuildingOptions
            {
                Name = "NA_MixedSignature01",
                Attractiveness = 5,
                Wellbeing = 4,
                Radius = 750,
                CityAttractiveness = 0.010f,
                Noisepollution = 1500

            },
            new SignatureMixedbuildingOptions
            {
                Name = "NA_MixedSignature02",
                Attractiveness = 10,
                Wellbeing = 8,
                Radius = 1250,
                CityAttractiveness = 0.010f,
                Noisepollution = 1500

            },
            new SignatureMixedbuildingOptions
            {
                Name = "NA_MixedSignature03",
                Attractiveness = 15,
                Wellbeing = 10,
                Radius = 1500,
                CityAttractiveness = 0.010f,
                Noisepollution = 1500

            }
        },

        FireStation_Options = new List<FireStationOptions>
        {
            new FireStationOptions
            {
                Name = "FireStation01",
                Upkeep = 235000,
                ElectricityConsumption = 3500,
                WaterConsumption = 5000,
                GarbageAccumulation = 3200,
                Noisepollution = 7500,
                FireEngineCapacity = 10,
                FireHelicopterCapacity = 0,
                VehicleEfficiency = 1,
                DisasterResponseCapacity = 0,
                Range = 10000,
                Capacity = 100000,
                Magnitude = 10

            },
            new FireStationOptions
            {
                Name = "FireHouse01",
                Upkeep = 20000,
                ElectricityConsumption = 1000,
                WaterConsumption = 1000,
                GarbageAccumulation = 700,
                Noisepollution = 5000,
                FireEngineCapacity = 4,
                FireHelicopterCapacity = 0,
                VehicleEfficiency = 1,
                DisasterResponseCapacity = 0,
                Range = 5000,
                Capacity = 25000,
                Magnitude = 5

            }
        },

        FireHelicopterDepot_Options = new List<FireHelicopterDepotOptions>
        {
            new FireHelicopterDepotOptions
            {
                Name = "FireHelicopterDepot01",
                Upkeep = 145000,
                ElectricityConsumption = 16000,
                WaterConsumption = 4000,
                GarbageAccumulation = 5300,
                Noisepollution = 25000,
                FireEngineCapacity = 0,
                FireHelicopterCapacity = 5,
                VehicleEfficiency = 1,
                DisasterResponseCapacity = 0
             
            }
        },

        FirewatchTower_Options = new List<FirewatchTowerOptions>
        {
            new FirewatchTowerOptions
            {
                Name = "FirewatchtTower01",
                Upkeep = 25000,
                ElectricityConsumption = 500,
                ForestFireResponseTime = -0.8f,
                ForestResponseRadius = 1000f,
                ForestFireHazard = -0.1f,
                ForestFireHazardRadius = 1000f

            }
        }
    };

    public IEnumerable<SchoolOptions> School_Options { get; set; }
    public IEnumerable<PowerplantOptions> Powerplant_Options { get; set; }
    public IEnumerable<WaterpumpOptions> Waterpump_Options { get; set; }
    public IEnumerable<TransformerstationOptions> Transformerstation_Options { get; set; }
    public IEnumerable<ServerfarmOptions> Serverfarm_Options { get; set; }
    public IEnumerable<GarbagetruckOptions> Garbagetruck_Options { get; set; }
    public IEnumerable<TransportbusOptions> Transportbus_Options { get; set; }
    public IEnumerable<ParkinghallOptions> Parkinghall_Options { get; set; }
    public IEnumerable<CityparkOptions> Citypark_Options { get; set; }
    public IEnumerable<WastewaterOptions> Wastewater_Options { get; set; }
    public IEnumerable<IncinerationPlantOptions> IncinerationPlant_Options { get; set; }
    public IEnumerable<HealthcareOptions> Healthcare_Options { get; set; }
    public IEnumerable<PostofficeOptions> Postoffice_Options { get; set; }
    public IEnumerable<CemeteryOptions> Cemetery_Options { get; set; }
    public IEnumerable<CrematoriumOptions> Crematorium_Options { get; set; }
    public IEnumerable<WindturbineOptions> Windturbine_Options { get; set; }
    public IEnumerable<EmergencybatteryOptions> Emergencybattery_Options { get; set; }
    public IEnumerable<GeothermalpowerplantOptions> Geothermalpowerplant_Options { get; set; }
    public IEnumerable<SolarpowerstationOptions> Solarpowerstation_Options { get; set; }
    public IEnumerable<SignatureResidentialbuildingOptions> SignatureResidentialbuilding_Options { get; set; }
    public IEnumerable<SignatureCommercialbuildingOptions> SignatureCommercialbuilding_Options { get; set; }
    public IEnumerable<PostVanOptions> PostVan_Options { get; set; }
    public IEnumerable<SignatureOfficebuildingOptions> SignatureOfficebuilding_Options { get; set; }
    public IEnumerable<SignatureMixedbuildingOptions> SignatureMixedbuilding_Options { get; set; }
    public IEnumerable<FireStationOptions> FireStation_Options { get; set; }
    public IEnumerable<FireHelicopterDepotOptions> FireHelicopterDepot_Options { get; set; }
    public IEnumerable<FirewatchTowerOptions> FirewatchTower_Options { get; set; }





    public IReadOnlyDictionary<string, SchoolOptions> GetSchoolDictionary()
    {
        var schooldict = new Dictionary<string, SchoolOptions>();
        foreach (var School_option in School_Options)
        {
            schooldict.Add(School_option.Name, School_option);
        }
        return schooldict;
    }
    public IReadOnlyDictionary<string, PowerplantOptions> GetPowerplantDictionary()
    {
        var Powerplantdict = new Dictionary<string, PowerplantOptions>();
        foreach (var Powerplant_option in Powerplant_Options)
        {
            Powerplantdict.Add(Powerplant_option.Name, Powerplant_option);
        }
        return Powerplantdict;
    }
    public IReadOnlyDictionary<string, WaterpumpOptions> GetWaterpumpDictionary()
    {
        var Waterpumpdict = new Dictionary<string, WaterpumpOptions>();
        foreach (var Waterpump_option in Waterpump_Options)
        {
            Waterpumpdict.Add(Waterpump_option.Name, Waterpump_option);
        }
        return Waterpumpdict;
    }
    public IReadOnlyDictionary<string, TransformerstationOptions> GetTransformerstationDictionary()
    {
        var Transformerstationdict = new Dictionary<string, TransformerstationOptions>();
        foreach (var Transformerstation_option in Transformerstation_Options)
        {
            Transformerstationdict.Add(Transformerstation_option.Name, Transformerstation_option);
        }
        return Transformerstationdict;
    }
    public IReadOnlyDictionary<string, ServerfarmOptions> GetServerfarmDictionary()
    {
        var Serverfarmdict = new Dictionary<string, ServerfarmOptions>();
        foreach (var Serverfarm_option in Serverfarm_Options)
        {
            Serverfarmdict.Add(Serverfarm_option.Name, Serverfarm_option);
        }
        return Serverfarmdict;
    }
    public IReadOnlyDictionary<string, GarbagetruckOptions> GetGarbagetruckDictionary()
    {
        var Garbagetruckdict = new Dictionary<string, GarbagetruckOptions>();
        foreach (var Garbagetruck_option in Garbagetruck_Options)
        {
            Garbagetruckdict.Add(Garbagetruck_option.Name, Garbagetruck_option);
        }
        return Garbagetruckdict;
    }
    public IReadOnlyDictionary<string, TransportbusOptions> GetTransportbusDictionary()
    {
        var Transportbusdict = new Dictionary<string, TransportbusOptions>();
        foreach (var Transportbus_option in Transportbus_Options)
        {
            Transportbusdict.Add(Transportbus_option.Name, Transportbus_option);
        }
        return Transportbusdict;
    }
    public IReadOnlyDictionary<string, ParkinghallOptions> GetParkinghallDictionary()
    {
        var Parkinghalldict = new Dictionary<string, ParkinghallOptions>();
        foreach (var Parkinghall_option in Parkinghall_Options)
        {
            Parkinghalldict.Add(Parkinghall_option.Name, Parkinghall_option);
        }
        return Parkinghalldict;
    }
    public IReadOnlyDictionary<string, CityparkOptions> GetCityparkDictionary()
    {
        var Cityparkdict = new Dictionary<string, CityparkOptions>();
        foreach (var Citypark_option in Citypark_Options)
        {
            Cityparkdict.Add(Citypark_option.Name, Citypark_option);
        }
        return Cityparkdict;
    }
    public IReadOnlyDictionary<string, WastewaterOptions> GetWastewaterDictionary()
    {
        var Wastewaterdict = new Dictionary<string, WastewaterOptions>();
        foreach (var Wastewater_option in Wastewater_Options)
        {
            Wastewaterdict.Add(Wastewater_option.Name, Wastewater_option);
        }
        return Wastewaterdict;
    }
    public IReadOnlyDictionary<string, IncinerationPlantOptions> GetIncinerationPlantDictionary()
    {
        var IncinerationPlantdict = new Dictionary<string, IncinerationPlantOptions>();
        foreach (var IncinerationPlant_option in IncinerationPlant_Options)
        {
            IncinerationPlantdict.Add(IncinerationPlant_option.Name, IncinerationPlant_option);
        }
        return IncinerationPlantdict;
    }
    public IReadOnlyDictionary<string, HealthcareOptions> GetHealthcareDictionary()
    {
        var Healthcaredict = new Dictionary<string, HealthcareOptions>();
        foreach (var Healthcare_option in Healthcare_Options)
        {
            Healthcaredict.Add(Healthcare_option.Name, Healthcare_option);
        }
        return Healthcaredict;
    }
    public IReadOnlyDictionary<string, PostofficeOptions> GetPostofficeDictionary()
    {
        var Postofficedict = new Dictionary<string, PostofficeOptions>();
        foreach (var Postoffice_option in Postoffice_Options)
        {
            Postofficedict.Add(Postoffice_option.Name, Postoffice_option);
        }
        return Postofficedict;
    }
    public IReadOnlyDictionary<string, CemeteryOptions> GetCemeteryDictionary()
    {
        var Cemeterydict = new Dictionary<string, CemeteryOptions>();
        foreach (var Cemetery_option in Cemetery_Options)
        {
            Cemeterydict.Add(Cemetery_option.Name, Cemetery_option);
        }
        return Cemeterydict;
    }
    public IReadOnlyDictionary<string, CrematoriumOptions> GetCrematoriumDictionary()
    {
        var Crematoriumdict = new Dictionary<string, CrematoriumOptions>();
        foreach (var Crematorium_option in Crematorium_Options)
        {
            Crematoriumdict.Add(Crematorium_option.Name, Crematorium_option);
        }
        return Crematoriumdict;
    }
    public IReadOnlyDictionary<string, WindturbineOptions> GetWindturbineDictionary()
    {
        var Windturbinedict = new Dictionary<string, WindturbineOptions>();
        foreach (var Windturbine_option in Windturbine_Options)
        {
            Windturbinedict.Add(Windturbine_option.Name, Windturbine_option);
        }
        return Windturbinedict;
    }
    public IReadOnlyDictionary<string, EmergencybatteryOptions> GetEmergencybatteryDictionary()
    {
        var Emergencybatterydict = new Dictionary<string, EmergencybatteryOptions>();
        foreach (var Emergencybattery_option in Emergencybattery_Options)
        {
            Emergencybatterydict.Add(Emergencybattery_option.Name, Emergencybattery_option);
        }
        return Emergencybatterydict;
    }
    public IReadOnlyDictionary<string, GeothermalpowerplantOptions> GetGeothermalpowerplantDictionary()
    {
        var Geothermalpowerplantdict = new Dictionary<string, GeothermalpowerplantOptions>();
        foreach (var Geothermalpowerplant_option in Geothermalpowerplant_Options)
        {
            Geothermalpowerplantdict.Add(Geothermalpowerplant_option.Name, Geothermalpowerplant_option);
        }
        return Geothermalpowerplantdict;
    }
    public IReadOnlyDictionary<string, SolarpowerstationOptions> GetSolarpowerstationDictionary()
    {
        var Solarpowerstationdict = new Dictionary<string, SolarpowerstationOptions>();
        foreach (var Solarpowerstation_option in Solarpowerstation_Options)
        {
            Solarpowerstationdict.Add(Solarpowerstation_option.Name, Solarpowerstation_option);
        }
        return Solarpowerstationdict;
    }
    public IReadOnlyDictionary<string, SignatureResidentialbuildingOptions> GetSignatureResidentialbuildingDictionary()
    {
        var SignatureResidentialbuildingdict = new Dictionary<string, SignatureResidentialbuildingOptions>();
        foreach (var SignatureResidentialbuilding_option in SignatureResidentialbuilding_Options)
        {
            SignatureResidentialbuildingdict.Add(SignatureResidentialbuilding_option.Name, SignatureResidentialbuilding_option);
        }
        return SignatureResidentialbuildingdict;
    }
    public IReadOnlyDictionary<string, SignatureCommercialbuildingOptions> GetSignatureCommercialbuildingDictionary()
    {
        var SignatureCommercialbuildingdict = new Dictionary<string, SignatureCommercialbuildingOptions>();
        foreach (var SignatureCommercialbuilding_option in SignatureCommercialbuilding_Options)
        {
            SignatureCommercialbuildingdict.Add(SignatureCommercialbuilding_option.Name, SignatureCommercialbuilding_option);
        }
        return SignatureCommercialbuildingdict;
    }
    public IReadOnlyDictionary<string, PostVanOptions> GetPostVanDictionary()
    {
        var PostVandict = new Dictionary<string, PostVanOptions>();
        foreach (var PostVan_option in PostVan_Options)
        {
            PostVandict.Add(PostVan_option.Name, PostVan_option);
        }
        return PostVandict;
    }
    public IReadOnlyDictionary<string, SignatureOfficebuildingOptions> GetSignatureOfficebuildingDictionary()
    {
        var SignatureOfficebuildingdict = new Dictionary<string, SignatureOfficebuildingOptions>();
        foreach (var SignatureOfficebuilding_option in SignatureOfficebuilding_Options)
        {
            SignatureOfficebuildingdict.Add(SignatureOfficebuilding_option.Name, SignatureOfficebuilding_option);
        }
        return SignatureOfficebuildingdict;
    }
    public IReadOnlyDictionary<string, SignatureMixedbuildingOptions> GetSignatureMixedbuildingDictionary()
    {
        var SignatureMixedbuildingdict = new Dictionary<string, SignatureMixedbuildingOptions>();
        foreach (var SignatureMixedbuilding_option in SignatureMixedbuilding_Options)
        {
            SignatureMixedbuildingdict.Add(SignatureMixedbuilding_option.Name, SignatureMixedbuilding_option);
        }
        return SignatureMixedbuildingdict;
    }
    public IReadOnlyDictionary<string, FireStationOptions> GetFireStationDictionary()
    {
        var FireStationdict = new Dictionary<string, FireStationOptions>();
        foreach (var FireStation_option in FireStation_Options)
        {
            FireStationdict.Add(FireStation_option.Name, FireStation_option);
        }
        return FireStationdict;
    }
    public IReadOnlyDictionary<string, FireHelicopterDepotOptions> GetFireHelicopterDepotDictionary()
    {
        var FireHelicopterDepotdict = new Dictionary<string, FireHelicopterDepotOptions>();
        foreach (var FireHelicopterDepot_option in FireHelicopterDepot_Options)
        {
            FireHelicopterDepotdict.Add(FireHelicopterDepot_option.Name, FireHelicopterDepot_option);
        }
        return FireHelicopterDepotdict;
    }
    public IReadOnlyDictionary<string, FirewatchTowerOptions> GetFirewatchTowerDictionary()
    {
        var FirewatchTowerdict = new Dictionary<string, FirewatchTowerOptions>();
        foreach (var FirewatchTower_option in FirewatchTower_Options)
        {
            FirewatchTowerdict.Add(FirewatchTower_option.Name, FirewatchTower_option);
        }
        return FirewatchTowerdict;
    }


    public void RemoveBadEntires()
    {
         School_Options = School_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) && 
            x.UpkeepCost >= 0 &&
            x.AirPollution >= 0 &&
            x.GroundPollution >= 0 &&
            x.NoisePollution >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Waterconsumption >= 0 &&
            x.Electricityconsumption >= 0);
   
        
        Powerplant_Options = Powerplant_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.AirPollution >= 0 &&
            x.GroundPollution >= 0 &&
            x.NoisePollution >= 0 &&
            x.Production >= 0);

        
        Waterpump_Options = Waterpump_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Capacity >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.ElectricityConsumption >= 0 &&
            x.NoisePollution >= 0);

        
        Transformerstation_Options = Transformerstation_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.NoisePollution >= 0);

        
        Serverfarm_Options = Serverfarm_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.NoisePollution >= 0);

       
        Garbagetruck_Options = Garbagetruck_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Capacity >= 0 &&
            x.Unloadrate >= 0);

        
        Transportbus_Options = Transportbus_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Passengercapacity >= 0 &&
            x.Maintenancerange >= 0);

        
        Parkinghall_Options = Parkinghall_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.GarageCapacity >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Noisepollution >= 0 &&
            x.Comfortfactor >= 0);

        
        Citypark_Options = Citypark_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0 &&
            x.Efficiency >= 0 &&
            x.Attractiveness >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0);

        
        Wastewater_Options = Wastewater_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Capacity >= 0 &&
            x.Purification >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.GroundPollution >= 0 &&
            x.AirPollution >= 0 &&
            x.NoisePollution >= 0 &&
            x.ElectricityConsumption >= 0);

        
        IncinerationPlant_Options = IncinerationPlant_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Garbagecapacity >= 0 &&
            x.Vehiclecapacity >= 0 &&
            x.Transportcapacity >= 0 &&
            x.Processingspeed >= 0 &&
            x.Electricityproduction >= 0 &&
            x.Productionperunit >= 0 &&
            x.ProductionCapacity >= 0 &&
            x.Waterconsumption >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.CityIndustrialGroundPollution <= 0 &&
            x.GroundPollution >= 0 &&
            x.AirPollution >= 0 &&
            x.NoisePollution >= 0);

        
        Healthcare_Options = Healthcare_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Waterconsumption >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.NoisePollution >= 0 &&
            x.Ambulancecapacity >= 0 &&
            x.Helicoptercapacity >= 0 &&
            x.Patientcapacity >= 0 &&
            x.Treatmentbonus >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0);

        Postoffice_Options = Postoffice_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Waterconsumption >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Noisepollution >= 0 &&
            x.Mailstoragecapacity >= 0 &&
            x.Mailboxcapacity >= 0 &&
            x.Postvancapacity >= 0 &&
            x.PostTruckscapacity >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0);

        Cemetery_Options = Cemetery_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Waterconsumption >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Hearsecapacity >= 0 &&
            x.Storagecapacity >= 0 &&
            x.Efficiency >= 0);

        Crematorium_Options = Crematorium_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Waterconsumption >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Hearsecapacity >= 0 &&
            x.Storagecapacity >= 0 &&
            x.Airpollution >= 0 &&
            x.Noisepollution >= 0 &&
            x.Processingrate >= 0);

        Windturbine_Options = Windturbine_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Production >= 0 &&
            x.Maximumwind >= 0 &&
            x.Noisepollution >= 0);

        Emergencybattery_Options = Emergencybattery_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Capacity >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Poweroutput >= 0 &&
            x.Noisepollution >= 0);

        Geothermalpowerplant_Options = Geothermalpowerplant_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Production >= 0 &&
            x.Maximumgroundwater >= 0 &&
            x.AirPollution >= 0 &&
            x.GroundPollution >= 0 &&
            x.NoisePollution >= 0);

        Solarpowerstation_Options = Solarpowerstation_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Production >= 0 &&
            x.Poweroutput >= 0 &&
            x.Capacity >= 0 &&
            x.NoisePollution >= 0);

        SignatureResidentialbuilding_Options = SignatureResidentialbuilding_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Wellbeing >= 0 &&
            x.Radius >= 0);

        SignatureCommercialbuilding_Options = SignatureCommercialbuilding_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Wellbeing >= 0 &&
            x.Radius >= 0 &&
            x.Attractiveness >= 0 &&
            x.CityImportcost <= 0 &&
            x.CityAttractiveness >= 0 &&
            x.Noisepollution >= 0);

        PostVan_Options = PostVan_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.MailCapacity >= 0);

        SignatureOfficebuilding_Options = SignatureOfficebuilding_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Wellbeing >= 0 &&
            x.Radius >= 0 &&
            x.Attractiveness >= 0 &&
            x.CrimeAccumulation <= 0 &&
            x.CrimeRadius >= 0 &&
            x.CityOfficeEfficency >= 0 &&
            x.CityUniversityGraduation >= 0 &&
            x.CityUniversityInterest >= 0 &&
            x.Noisepollution >= 0);

        SignatureMixedbuilding_Options = SignatureMixedbuilding_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Wellbeing >= 0 &&
            x.Radius >= 0 &&
            x.Attractiveness >= 0 &&
            x.Wellbeing >= 0 &&
            x.Radius >= 0 &&
            x.CityAttractiveness >= 0 &&
            x.Noisepollution >= 0);

        FireStation_Options = FireStation_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.ElectricityConsumption >= 0 &&
            x.WaterConsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Noisepollution >= 0 &&
            x.FireEngineCapacity >= 0 &&
            x.FireHelicopterCapacity >= 0 &&
            x.VehicleEfficiency >= 0 &&
            x.DisasterResponseCapacity >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0);

        FireHelicopterDepot_Options = FireHelicopterDepot_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.ElectricityConsumption >= 0 &&
            x.WaterConsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Noisepollution >= 0 &&
            x.FireEngineCapacity >= 0 &&
            x.FireHelicopterCapacity >= 0 &&
            x.VehicleEfficiency >= 0 &&
            x.DisasterResponseCapacity >= 0);

        FirewatchTower_Options = FirewatchTower_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.ElectricityConsumption >= 0 &&
            x.ForestFireResponseTime <= 0 &&
            x.ForestResponseRadius >= 0 &&
            x.ForestFireHazard <= 0 &&
            x.ForestFireHazardRadius >= 0);

    }
}