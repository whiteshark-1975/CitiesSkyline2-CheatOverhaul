using Colossal.OdinSerializer.Utilities;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.InputSystem.Utilities;

namespace WhitesharkCheatOverhaul;

public class WhitesharkCheatOverhaulOptions
{
    public static WhitesharkCheatOverhaulOptions Default => new WhitesharkCheatOverhaulOptions
    {
        Version = 323,
        School_Options = new List<SchoolOptions>
        {
            new SchoolOptions
            {
                Name = "ElementarySchool01",
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
                UpkeepCost = 655555,
                Waterconsumption = 48000,
                GarbageAccumulation = 30000,
                AirPollution = 10000,
                GroundPollution = 10000,
                NoisePollution = 10000,
                Production = 2500000,
                Storage = 5000
            },

            new PowerplantOptions
            {
                Name = "GasPowerPlant01 Additional Turbine",
                UpkeepCost = 200000,
                Waterconsumption = 24000,
                GarbageAccumulation = 6000,
                AirPollution = 3000,
                GroundPollution = 3000,
                NoisePollution = 3000,
                Production = 1000000
            },

            new PowerplantOptions
            {
                Name = "GasPowerPlant01 Advanced Furnace",
                UpkeepCost = 80000,
                Waterconsumption = 0,
                GarbageAccumulation = 0
            },


            new PowerplantOptions
            {
                Name = "GasPowerPlant01 Exhaust Filter",
                UpkeepCost = 100000,
                Waterconsumption = 0,
                GarbageAccumulation = 7500,
                
            },

            new PowerplantOptions
            {
                Name = "GasPowerPlant01 Fuel Storage Extention",
                UpkeepCost = 150000,
                Waterconsumption = 0,
                GarbageAccumulation = 6000,
                AirPollution = 5000,
                GroundPollution = 5000,
                NoisePollution = 5000,
                Storage = 2500
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
                Production = 3000000,
                Storage = 500000
                
            },

            new PowerplantOptions
            {
                Name = "CoalPowerPlant01 Additional Turbine Building",
                UpkeepCost = 50000,
                Waterconsumption = 30000,
                GarbageAccumulation = 10000,
                AirPollution = 50000,
                GroundPollution = 50000,
                NoisePollution = 50000,
                Production = 1000000,
            },

            new PowerplantOptions
            {
                Name = "CoalPowerPlant01 Exhaust Filter",
                UpkeepCost = 50000,
                Waterconsumption = 0,
                GarbageAccumulation = 12500

            },
            new PowerplantOptions
            {
                Name = "CoalPowerPlant01 Advanced Furnace",
                UpkeepCost = 60000,
                Waterconsumption = 0,
                GarbageAccumulation = 0

            },

            new PowerplantOptions
            {
                Name = "CoalPowerPlant01 Coal Storage Yard",
                UpkeepCost = 25000,
                GarbageAccumulation = 10000,
                AirPollution = 25000,
                GroundPollution = 25000,
                NoisePollution = 25000,
                Storage = 2500000

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
                UpkeepCost = 60000,
                Capacity = 100000,
                GarbageAccumulation = 12500,
                ElectricityConsumption = 3000,
                NoisePollution =5000
            },

            new WaterpumpOptions
            {
                Name = "WaterPumpingStation01 Extra Pump",
                UpkeepCost = 7000,
                Capacity = 50000,
                GarbageAccumulation = 2500,
                ElectricityConsumption = 1000,
                NoisePollution =2500
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
                Name = "GroundwaterPumpingStation01 Advanced Filtering System",
                UpkeepCost = 11000,
                Capacity = 0,
                GarbageAccumulation = 2500,
                ElectricityConsumption = 1000,
                Purification = 0.5f

            },

            new WaterpumpOptions
            {
                Name = "GroundwaterPumpingStation01 Extra Pump",
                UpkeepCost = 7000,
                Capacity = 37500,
                GarbageAccumulation = 2000,
                ElectricityConsumption = 500,
                NoisePollution =2500

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
            },

            new ServerfarmOptions
            {
                Name = "SatelliteUplink01",
                UpkeepCost = 320000,
                Electricityconsumption = 5000,
                Waterconsumption = 500,
                GarbageAccumulation = 5000,
                Range = 0,
                Capacity = 0,
                NoisePollution = 5000,
                CityEntertainment = 50f,
                CityTelecomCapacity = 0.2f,
                CityAttractiveness = 0.1f
            },

            new ServerfarmOptions
            {
                Name = "TelecomTower01",
                UpkeepCost = 95000,
                Electricityconsumption = 5000,
                Waterconsumption = 1000,
                GarbageAccumulation = 0,
                Range = 5000,
                Capacity = 15000,
                NoisePollution = 10000
            },
            new ServerfarmOptions
            {
                Name = "ServerFarm01 Fiber Optic Cable",
                UpkeepCost = 10000,
                Electricityconsumption = 10000,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                Range = 500,
                Capacity = 0,
                
            },
            new ServerfarmOptions
            {
                Name = "ServerFarm01 Server Upgrade",
                UpkeepCost = 20000,
                Electricityconsumption = 10000,
                Waterconsumption = 2500,
                GarbageAccumulation = 1000,
                Range = 0,
                Capacity = 10000,

               
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
                Name = "ParkingLot01",
                Upkeep = 2200,
                GarageCapacity = 0,
                Comfortfactor = 0.5f,
                Electricityconsumption = 200,
                Waterconsumption = 0,
                GarbageAccumulation = 200,
                Noisepollution = 2500
            },

            new ParkinghallOptions
            {
                Name = "ParkingLot02",
                Upkeep = 3000,
                GarageCapacity = 0,
                Comfortfactor = 0.5f,
                Electricityconsumption = 300,
                Waterconsumption = 0,
                GarbageAccumulation = 300,
                Noisepollution = 2500
            },

            new ParkinghallOptions
            {
                Name = "ParkingLot03",
                Upkeep = 7000,
                GarageCapacity = 0,
                Comfortfactor = 0.5f,
                Electricityconsumption = 700,
                Waterconsumption = 0,
                GarbageAccumulation = 700,
                Noisepollution = 5000
            },

            new ParkinghallOptions
            {
                Name = "ParkingLot04",
                Upkeep = 16000,
                GarageCapacity = 0,
                Comfortfactor = 0.5f,
                Electricityconsumption = 1600,
                Waterconsumption = 0,
                GarbageAccumulation = 1700,
                Noisepollution = 5000
            },

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
                Name = "ParkingHall01 Car Wash",
                Upkeep = 5000,
                GarageCapacity = 0,
                Comfortfactor = 0.1f,
                Electricityconsumption = 2400,
                Waterconsumption = 2000,
                GarbageAccumulation = 1600
                
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
            },

            new ParkinghallOptions
            {
                Name = "AutomatedParkingBuilding01",
                Upkeep = 130000,
                GarageCapacity = 416,
                Comfortfactor = 0.750f,
                Electricityconsumption = 7000,
                Waterconsumption = 3000,
                GarbageAccumulation = 2500,
                Noisepollution = 2500
            }
        },

        Citypark_Options = new List<CityparkOptions>
        {
            new CityparkOptions
            {
                Name = "CityPark01",
                Upkeep = 2000,
                ElectricityConsumption = 500,
                WaterConsumption = 0,
                GarbageAccumulation = 100,
                Range = 2500,
                Capacity = 800,
                Magnitude = 10,
                Attractiveness = 1,
                Efficiency = 1

            },

            new CityparkOptions
            {
                Name = "CityPark02",
                Upkeep = 4000,
                ElectricityConsumption = 750,
                WaterConsumption = 500,
                GarbageAccumulation = 200,
                Range = 4000,
                Capacity = 1200,
                Magnitude = 10,
                Attractiveness = 5,
                Efficiency = 2

            },

            new CityparkOptions
            {
            Name = "Playground01",
            Upkeep = 1000,
            ElectricityConsumption = 250,
            WaterConsumption = 0,
            GarbageAccumulation = 200,
            Range = 2000,
            Capacity = 600,
            Magnitude = 10,
            Attractiveness = 1,
            Efficiency = 2

            },

            new CityparkOptions
            {
            Name = "DogPark01",
            Upkeep = 2000,
            ElectricityConsumption = 250,
            WaterConsumption = 0,
            GarbageAccumulation = 200,
            Range = 3500,
            Capacity = 800,
            Magnitude = 10,
            Attractiveness = 1,
            Efficiency = 2

            },

            new CityparkOptions
            {
            Name = "CampireSite01",
            Upkeep = 6000,
            ElectricityConsumption = 0,
            WaterConsumption = 0,
            GarbageAccumulation = 400,
            Range = 6000,
            Capacity = 1600,
            Magnitude = 10,
            Attractiveness = 10,
            Efficiency = 5

            },

            new CityparkOptions
            {
            Name = "CityPark03",
            Upkeep = 8500,
            ElectricityConsumption = 10000,
            WaterConsumption = 750,
            GarbageAccumulation = 300,
            Range = 3000,
            Capacity = 1600,
            Magnitude = 14,
            Attractiveness = 10,
            Efficiency = 3

            },

            new CityparkOptions
            {
            Name = "CityPark04",
            Upkeep = 12500,
            ElectricityConsumption = 1500,
            WaterConsumption = 1000,
            GarbageAccumulation = 400,
            Range = 4000,
            Capacity = 2000,
            Magnitude = 14,
            Attractiveness = 15,
            Efficiency = 5

            },

            new CityparkOptions
            {
            Name = "Playground02",
            Upkeep = 2500,
            ElectricityConsumption = 500,
            WaterConsumption = 0,
            GarbageAccumulation = 400,
            Range = 2500,
            Capacity = 800,
            Magnitude = 14,
            Attractiveness = 5,
            Efficiency = 5

            },

            new CityparkOptions
            {
            Name = "TennisCourt01",
            Upkeep = 2500,
            ElectricityConsumption = 500,
            WaterConsumption = 0,
            GarbageAccumulation = 400,
            Range = 3500,
            Capacity = 800,
            Magnitude = 14,
            Attractiveness = 5,
            Efficiency = 5

            },

            new CityparkOptions
            {
            Name = "GymPark01",
            Upkeep = 3000,
            ElectricityConsumption = 500,
            WaterConsumption = 0,
            GarbageAccumulation = 400,
            Range = 3500,
            Capacity = 1000,
            Magnitude = 10,
            Attractiveness = 5,
            Efficiency = 5

            },

            new CityparkOptions
            {
            Name = "SkatePark01",
            Upkeep = 3000,
            ElectricityConsumption = 500,
            WaterConsumption = 0,
            GarbageAccumulation = 400,
            Range = 3500,
            Capacity = 1000,
            Magnitude = 10,
            Attractiveness = 5,
            Efficiency = 5

            },

            new CityparkOptions
            {
            Name = "BasketballCourt01",
            Upkeep = 2500,
            ElectricityConsumption = 510,
            WaterConsumption = 0,
            GarbageAccumulation = 400,
            Range = 3500,
            Capacity = 800,
            Magnitude = 14,
            Attractiveness = 5,
            Efficiency = 5

            },

            new CityparkOptions
            {
            Name = "AmericanFootballField01",
            Upkeep = 30000,
            ElectricityConsumption = 2500,
            WaterConsumption = 0,
            GarbageAccumulation = 1500,
            Range = 4000,
            Capacity = 4000,
            Magnitude = 16,
            Attractiveness = 25,
            Efficiency = 25

            },

            new CityparkOptions
            {
            Name = "FootballField01",
            Upkeep = 30000,
            ElectricityConsumption = 2510,
            WaterConsumption = 0,
            GarbageAccumulation = 1500,
            Range = 4000,
            Capacity = 4000,
            Magnitude = 16,
            Attractiveness = 25,
            Efficiency = 20

            },

            new CityparkOptions
            {
            Name = "CommunityPool01",
            Upkeep = 16000,
            ElectricityConsumption = 3000,
            WaterConsumption = 10000,
            GarbageAccumulation = 1500,
            Range = 3500,
            Capacity = 2000,
            Magnitude = 16,
            Attractiveness = 15,
            Efficiency = 20

            },

            new CityparkOptions
            {
            Name = "ObservationTower01",
            Upkeep = 320000,
            ElectricityConsumption = 3500,
            WaterConsumption = 5000,
            GarbageAccumulation = 5700,
            Range = 7500,
            Capacity = 6000,
            Magnitude = 18,
            Attractiveness = 40,
            Efficiency = 75

            },

            new CityparkOptions
            {
            Name = "BronzeStatue01",
            Upkeep = 320000,
            ElectricityConsumption = 3000,
            WaterConsumption = 1000,
            GarbageAccumulation = 1900,
            Range = 5000,
            Capacity = 5000,
            Magnitude = 16,
            Attractiveness = 50,
            Efficiency = 25

            },

            new CityparkOptions
            {
            Name = "WaterPark01",
            Upkeep = 80000,
            ElectricityConsumption = 15000,
            WaterConsumption = 20000,
            GarbageAccumulation = 1900,
            Range = 5000,
            Capacity = 3000,
            Magnitude = 16,
            Attractiveness = 75,
            Efficiency = 25

            },

            new CityparkOptions
            {
            Name = "OldCastle01",
            Upkeep = 480000,
            ElectricityConsumption = 1000,
            WaterConsumption = 1000,
            GarbageAccumulation = 1500,
            Range = 7500,
            Capacity = 4000,
            Magnitude = 16,
            Attractiveness = 85,
            Efficiency = 20

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
                Name = "WastewaterTreatmentPlant01 Advanced Filtering System",
                UpkeepCost = 20000,
                Capacity = 0,
                Purification = 0.1f,
                GarbageAccumulation = 12500,
                GroundPollution = 0,
                AirPollution = 0,
                NoisePollution = 0,
                ElectricityConsumption = 2000
            },

            new WastewaterOptions
            {
                Name = "WastewaterTreatmentPlant01 Extra Processing Unit",
                UpkeepCost = 40000,
                Capacity = 100000,
                Purification = 0f,
                GarbageAccumulation = 10000,
                GroundPollution = 2500,
                AirPollution = 2500,
                NoisePollution = 7500,
                ElectricityConsumption = 1000
            },

            new WastewaterOptions
            {
                Name = "SewageOutlet01",
                UpkeepCost = 20000,
                Capacity = 100000,
                Purification = 0f,
                GarbageAccumulation = 0,
                GroundPollution = 0,
                AirPollution = 5000,
                NoisePollution = 5000,
                ElectricityConsumption = 0
            },

            new WastewaterOptions
            {
                Name = "SewageOutlet01 Chemical Purification",
                UpkeepCost = 4000,
                Capacity = 0,
                Purification = 0.25f,
                GarbageAccumulation = 0,
                GroundPollution = 0,
                AirPollution = 2500,
                NoisePollution = 5000,
                ElectricityConsumption = 0
            },

            new WastewaterOptions
            {
                Name = "SewageOutlet01 Extra Settling Tank",
                UpkeepCost = 10000,
                Capacity = 0,
                Purification = 0.1f,
                GarbageAccumulation = 0,
                GroundPollution = 2500,
                AirPollution = 2500,
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
                Name = "MedicalClinic01 Ambulance Depot",
                UpkeepCost = 7000,
                Waterconsumption = 250,
                Electricityconsumption = 500,
                GarbageAccumulation = 400,
                Ambulancecapacity = 5,
                Helicoptercapacity = 0,
                Patientcapacity = 0,
                Treatmentbonus = 0
                
            },

            new HealthcareOptions
            {
                Name = "MedicalClinic01 Extention Wing",
                UpkeepCost = 25000,
                Waterconsumption = 500,
                Electricityconsumption = 1000,
                GarbageAccumulation = 700,
                Ambulancecapacity = 0,
                Helicoptercapacity = 0,
                Patientcapacity = 25,
                Treatmentbonus = 0

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
            },

            new HealthcareOptions
            {
                Name = "Hospital01 Helipad",
                UpkeepCost = 35000,
                Waterconsumption = 250,
                Electricityconsumption = 1000,
                GarbageAccumulation = 1000,
                Ambulancecapacity = 0,
                Helicoptercapacity = 1,
                Patientcapacity = 0,
                Treatmentbonus = 0
                
            },

            new HealthcareOptions
            {
                Name = "Hospital01 Special Ward",
                UpkeepCost = 100000,
                Waterconsumption = 2500,
                Electricityconsumption = 2000,
                GarbageAccumulation = 3200,
                Ambulancecapacity = 0,
                Helicoptercapacity = 0,
                Patientcapacity = 0,
                Treatmentbonus = 0
                
            },

            new HealthcareOptions
            {
                Name = "Hospital01 Trauma Center",
                UpkeepCost = 80000,
                Waterconsumption = 2500,
                Electricityconsumption = 2000,
                GarbageAccumulation = 3200,
                Ambulancecapacity = 0,
                Helicoptercapacity = 0,
                Patientcapacity = 0,
                Treatmentbonus = 15
                
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
                Magnitude = 2,
                SortingRate = 0

            },

            new PostofficeOptions
            {
                Name = "PostOffice01 Post Van Garage",
                Upkeep = 6000,
                Waterconsumption = 250,
                Electricityconsumption = 350,
                GarbageAccumulation = 900,
                Noisepollution = 2500,
                Mailboxcapacity = 0,
                Postvancapacity = 10,
                PostTruckscapacity = 0,
                Mailstoragecapacity = 0,
                SortingRate = 0

            },
            
            new PostofficeOptions
            {
                Name = "PostOffice01 Mail Storage Extention",
                Upkeep = 5000,
                Waterconsumption = 0,
                Electricityconsumption = 350,
                GarbageAccumulation = 400,
                Noisepollution = 2500,
                Mailboxcapacity = 0,
                Postvancapacity = 0,
                PostTruckscapacity = 0,
                Mailstoragecapacity = 25000,
                SortingRate = 0

            },

            new PostofficeOptions
            {
                Name = "PostSortingFacility01",
                Upkeep = 80000,
                Waterconsumption = 2500,
                Electricityconsumption = 8000,
                GarbageAccumulation = 9000,
                Noisepollution = 20000,
                Mailboxcapacity = 0,
                Postvancapacity = 0,
                PostTruckscapacity = 5,
                Mailstoragecapacity = 500000,
                SortingRate = 50000

            },
            new PostofficeOptions
            {
                Name = "PostSortingFacility01 Extra Loading Ramp",
                Upkeep = 10000,
                Waterconsumption = 0,
                Electricityconsumption = 0,
                GarbageAccumulation = 1800,
                Noisepollution = 5000,
                Mailboxcapacity = 0,
                Postvancapacity = 0,
                PostTruckscapacity = 5,
                Mailstoragecapacity = 0,
                SortingRate = 0

            },
            new PostofficeOptions
            {
                Name = "PostSortingFacility01 Automated Sorting",
                Upkeep = 80000,
                Waterconsumption = 2500,
                Electricityconsumption = 8000,
                GarbageAccumulation = 9000,
                Mailboxcapacity = 0,
                Postvancapacity = 0,
                PostTruckscapacity = 5,
                Mailstoragecapacity = 500000,
                SortingRate = 50000

            },

            new PostofficeOptions
            {
                Name = "PostSortingFacility01 Mail Storage Extention",
                Upkeep = 10000,
                Waterconsumption = 0,
                Electricityconsumption = 1500,
                GarbageAccumulation = 1800,
                Noisepollution = 5000,
                Mailboxcapacity = 0,
                Postvancapacity = 0,
                PostTruckscapacity = 5,
                Mailstoragecapacity = 250000,
                SortingRate = 0

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
        },

        PoliceStation_Options = new List<PoliceStationOptions>
        {
            new PoliceStationOptions
            {
                Name = "PoliceHeadquarters01",
                Upkeep = 310000,
                ElectricityConsumption = 3500,
                WaterConsumption = 2500,
                GarbageAccumulation = 3200,
                Noisepollution = 20000,
                PatrolCarCapacity = 20,
                PoliceHelicopterCapacity = 0,
                JailCapacity = 100,
                Range = 10000,
                Capacity = 100000,
                Magnitude = 8

            },

            new PoliceStationOptions
            {
                Name = "PoliceStation01",
                Upkeep = 38000,
                ElectricityConsumption = 2000,
                WaterConsumption = 1000,
                GarbageAccumulation = 700,
                Noisepollution = 5000,
                PatrolCarCapacity = 6,
                PoliceHelicopterCapacity = 0,
                JailCapacity = 25,
                Range = 5000,
                Capacity = 20000,
                Magnitude = 4

            }
        },

        Prison_Options = new List<PrisonOptions>
        {
            new PrisonOptions
            {
                Name = "Prison01",
                UpkeepCost = 200000,
                Electricityconsumption = 3500,
                Waterconsumption = 5000,
                GarbageAccumulation = 6300,
                NoisePollution = 40000,
                PrisonVanCapacity = 10,
                PrisonerCapacity = 500,
                CrimeAccumulation = -5f,
                CrimeAccumlationRadius = 800

            }

            
        },

        DiseaseControlCenter_Options = new List<DiseaseControlCenterOptions>
        {
            new DiseaseControlCenterOptions
            {
                Name = "DiseaseControlCenter01",
                Upkeep = 350000,
                Electricityconsumption = 10000,
                Waterconsumption = 5000,
                GarbageAccumulation = 4700,
                AmbulanceCapacity = 15,
                MedicalHelicopterCapacity = 2,
                PatientCapacity = 250,
                TreatmentBonus = 45,
                CityDiseaseprobability = -0.25f,
                CityPollutionhealthAffect = -0.25f
                
            }

        },

        HeathResearchInstitute_Options = new List<HeathResearchInstituteOptions>
        {
            new HeathResearchInstituteOptions
            {
                Name = "HeathResearchInstitute01",
                Upkeep = 160000,
                Electricityconsumption = 10000,
                Waterconsumption = 5000,
                GarbageAccumulation = 18800,
                CityDiseaseprobability = -0.1f,
                CityParkEntertainment = 0.1f

            }

        },

        RadioTelescope_Options = new List<RadioTelescopeOptions>
        {
            new RadioTelescopeOptions
            {
                Name = "RadioTelescope01",
                Upkeep = 200000,
                Electricityconsumption = 3500,
                Waterconsumption = 5000,
                GarbageAccumulation = 6300,
                CityUniversityGraduation = 5f

            }

        },

        GeologicalResearchCenter_Options = new List<GeologicalResearchCenterOptions>
        {
            new GeologicalResearchCenterOptions
            {
                Name = "GeologicalResearchCenter01",
                Upkeep = 230000,
                Electricityconsumption = 3500,
                Waterconsumption = 10000,
                GarbageAccumulation = 3800,
                Noisepollution = 15000,
                CityOreResourceAmmount = 2f,
                CityOilResourceAmmount = 2f,
                CityCollegegraduation = 3f

            }

        },

        TechnicalUniversity_Options = new List<TechnicalUniversityOptions>
        {
            new TechnicalUniversityOptions
            {
                Name = "TechnicalUniversity01",
                Upkeep = 160000,
                Electricityconsumption = 10000,
                Waterconsumption = 2500,
                GarbageAccumulation = 2900,
                StudentCapacity = 1500,
                NoisePollution = 10000,
                CityIndustrialEfficiency = 0.1f,
                CityOfficeEfficiency = 0.1f

            }

        },

        EarlyDisasterWarningSystem_Options = new List<EarlyDisasterWarningSystemOptions>
        {
            new EarlyDisasterWarningSystemOptions
            {
                Name = "EarlyDisasterWarningSystem01",
                Upkeep = 240000,
                Electricityconsumption = 15000,
                Waterconsumption = 7500,
                GarbageAccumulation = 6300,
                CityDisasterWarningTime = 360f,
                CityDisasterDamageRate = 0.2f

            }

        },

        WelfareOffice_Options = new List<WelfareOfficeOptions>
        {
            new WelfareOfficeOptions
            {
                Name = "WelfareOffice01",
                Upkeep = 45000,
                Electricityconsumption = 1500,
                Waterconsumption = 100,
                GarbageAccumulation = 3200,
                Range = 4000,
                Capacity = 20000,
                Magnitude = 12,
                NoisePollution = 10000

            }

        },

        CityHall_Options = new List<CityHallOptions>
        {
            new CityHallOptions
            {
                Name = "CityHall01",
                Upkeep = 160000,
                Electricityconsumption = 3500,
                Waterconsumption = 1000,
                GarbageAccumulation = 2500,
                CityLoanIntrest = -1f,
                CityImportCost = -0.02f
                
            }

        },

        LargeEmergencyShelter_Options = new List<LargeEmergencyShelterOptions>
        {
            new LargeEmergencyShelterOptions
            {
                Name = "LargeEmergencyShelter01",
                Upkeep = 60000,
                Electricityconsumption = 15000,
                Waterconsumption = 5000,
                GarbageAccumulation = 15700,
                ShelterCapacity = 25000,
                VehicleCapacity = 20,
                Range = 3000,
                Capacity= 50000,
                Magnitude = 10

            }

        },

        CentralBank_Options = new List<CentralBankOptions>
        {
            new CentralBankOptions
            {
                Name = "CentralBank01",
                Upkeep = 60000,
                Electricityconsumption = 15000,
                Waterconsumption = 5000,
                GarbageAccumulation = 15700,
                CityLoanIntrest = -2f,
                CityImportCost = -0.05f,
                CityExportCost = 0.05f

            }

        },

        MedicalUniversity_Options = new List<MedicalUniversityOptions>
        {
            new MedicalUniversityOptions
            {
                Name = "MedicalUniversity01",
                Upkeep = 240000,
                Electricityconsumption = 8000,
                Waterconsumption = 2500,
                GarbageAccumulation = 2900,
                StudentCapacity = 1500,
                NoisePollution = 10000,
                CityRecoverFailChange = -0.25f,
                CityHospitalEfficiency = 0.1f

            }

        },

        LargeHadronCollider_Options = new List<LargeHadronColliderOptions>
        {
            new LargeHadronColliderOptions
            {
                Name = "LargeHadronCollider01",
                Upkeep = 400000,
                Electricityconsumption = 100000,
                Waterconsumption = 250000,
                GarbageAccumulation = 18800,
                CityUniversityInterest = 0.15f,
                CityOfficeSoftwareDemand = 0.2f,
                CityIndustrialElectronicDemand = 0.2f,
                CityOfficeSoftwareEfficiency = 0.05f,
                CityIndustrialElectronicEfficiency = 0.05f
                
            }

        },

        PublicTransportStops_Options = new List<PublicTransportStopsOptions>
        {
            new PublicTransportStopsOptions
            {
                Name = "EU_BusStop01",
                EnterDistance = 10f,
                ExitDistance = 7f,
                AccessDistance = 4f,
                BoardingTime = 1.5f,
                ComfortFactor = 0.1f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "EU_BusStop02",
                EnterDistance = 10f,
                ExitDistance = 7f,
                AccessDistance = 6f,
                BoardingTime = 1f,
                ComfortFactor = 0.4f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "NA_BusStop01",
                EnterDistance = 10f,
                ExitDistance = 7f,
                AccessDistance = 4f,
                BoardingTime = 1.5f,
                ComfortFactor = 0.1f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "NA_BusStop02",
                EnterDistance = 10f,
                ExitDistance = 7f,
                AccessDistance = 6f,
                BoardingTime = 1f,
                ComfortFactor = 0.4f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "EU_TaxiStop01",
                EnterDistance = 20f,
                ExitDistance = 4f,
                AccessDistance = 2f,
                BoardingTime = 15f,
                ComfortFactor = 0.1f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "EU_TaxiStop02",
                EnterDistance = 20f,
                ExitDistance = 4f,
                AccessDistance = 3f,
                BoardingTime = 10f,
                ComfortFactor = 0.4f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "NA_TaxiStop01",
                EnterDistance = 20f,
                ExitDistance = 4f,
                AccessDistance = 2f,
                BoardingTime = 15f,
                ComfortFactor = 0.1f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "NA_TaxiStop02",
                EnterDistance = 20f,
                ExitDistance = 4f,
                AccessDistance = 3f,
                BoardingTime = 10f,
                ComfortFactor = 0.4f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "EU_TramStop01",
                EnterDistance = 0f,
                ExitDistance = 0f,
                AccessDistance = 13f,
                BoardingTime = 0.6f,
                ComfortFactor = 0.1f,
                LoadingFactor = 0

            },
            new PublicTransportStopsOptions
            {
                Name = "NA_TramStop01",
                EnterDistance = 0f,
                ExitDistance = 0f,
                AccessDistance = 13f,
                BoardingTime = 0.6f,
                ComfortFactor = 0.1f,
                LoadingFactor = 0

            }

        },

        PublicTransportDepots_Options = new List<PublicTransportDepotsOptions>
        {
            new PublicTransportDepotsOptions
            {
                Name = "BusDepot01",
                Upkeep = 62000,
                Electricityconsumption = 2000,
                Waterconsumption = 1000,
                GarbageAccumulation = 700,
                AirPollution = 2500,
                NoisePollution = 10000,
                VehicleCapacity = 25,
                MaintenanceDuration = 0.01f
            },
            new PublicTransportDepotsOptions
            {
                Name = "TaxiDepot01",
                Upkeep = 28000,
                Electricityconsumption = 1500,
                Waterconsumption = 500,
                GarbageAccumulation = 700,
                AirPollution = 0,
                NoisePollution = 5000,
                VehicleCapacity = 20,
                MaintenanceDuration = 0.007f
            },
            new PublicTransportDepotsOptions
            {
                Name = "RailYard01",
                Upkeep = 30000,
                Electricityconsumption = 7000,
                Waterconsumption = 1000,
                GarbageAccumulation = 1000,
                AirPollution = 0,
                NoisePollution = 30000,
                VehicleCapacity = 10,
                MaintenanceDuration = 0.014f
            },
            new PublicTransportDepotsOptions
            {
                Name = "TramDepot01",
                Upkeep = 23000,
                Electricityconsumption = 5000,
                Waterconsumption = 1000,
                GarbageAccumulation = 800,
                AirPollution = 0,
                NoisePollution = 15000,
                VehicleCapacity = 10,
                MaintenanceDuration = 0.014f
            },
            new PublicTransportDepotsOptions
            {
                Name = "SubwayYard01",
                Upkeep = 48000,
                Electricityconsumption = 8000,
                Waterconsumption = 1000,
                GarbageAccumulation = 1000,
                AirPollution = 0,
                NoisePollution = 25000,
                VehicleCapacity = 10,
                MaintenanceDuration = 0.014f
            }
        },

        PublicTransportStations_Options = new List<PublicTransportStationsOptions>
        {
            new PublicTransportStationsOptions
            {
                Name = "BusStation01",
                Upkeep = 56000,
                Electricityconsumption = 2500,
                Waterconsumption = 1000,
                GarbageAccumulation = 700,
                NoisePollution = 10000,
                ComfortFactor = 0.5f

            },
            new PublicTransportStationsOptions
            {
                Name = "TrainStation01",
                Upkeep = 23000,
                Electricityconsumption = 5000,
                Waterconsumption = 1000,
                GarbageAccumulation = 600,
                NoisePollution = 15000,
                ComfortFactor = 0.5f

            },
            new PublicTransportStationsOptions
            {
                Name = "CargoTrainTerminal01",
                Upkeep = 30000,
                Electricityconsumption = 11600,
                Waterconsumption = 1000,
                GarbageAccumulation = 1600,
                NoisePollution = 25000,
                StorageLimit = 15500000,
                Transports = 16

            },
            new PublicTransportStationsOptions
            {
                Name = "SubwayStation01",
                Upkeep = 10000,
                Electricityconsumption = 5000,
                Waterconsumption = 1000,
                GarbageAccumulation = 500,
                NoisePollution = 5000,
                ComfortFactor = 0.5f

            },
            new PublicTransportStationsOptions
            {
                Name = "SubwayStation02",
                Upkeep = 10000,
                Electricityconsumption = 8000,
                Waterconsumption = 1000,
                GarbageAccumulation = 500,
                NoisePollution = 10000,
                ComfortFactor = 0.5f

            },
            new PublicTransportStationsOptions
            {
                Name = "Harbor01",
                Upkeep = 60000,
                Electricityconsumption = 16000,
                Waterconsumption = 1000,
                GarbageAccumulation = 3200,
                NoisePollution = 25000,
                ComfortFactor = 0.5f

            },
            new PublicTransportStationsOptions
            {
                Name = "CargoHarbor01",
                Upkeep = 67000,
                Electricityconsumption = 25000,
                Waterconsumption = 1000,
                GarbageAccumulation = 6300,
                NoisePollution = 100000,
                StorageLimit = 15500000,
                Transports = 24

            }
        },

        Airport_Options = new List<AirportOptions>
        {
            new AirportOptions
            {
                Name = "Airport01",
                Upkeep = 100000,
                Electricityconsumption = 30000,
                Waterconsumption = 5000,
                GarbageAccumulation = 6300,
                Transports = 8,
                ComfortFactor = 0.5f,
                Attractiveness = 0.05f,
                OfficeEfficiency = 0.03f

            },
            new AirportOptions
            {
                Name = "InternationalAirport01",
                Upkeep = 100000,
                Electricityconsumption = 60000,
                Waterconsumption = 10000,
                GarbageAccumulation = 31300,
                Transports = 8,
                ComfortFactor = 0.9f,
                Attractiveness = 0.1f,
                UniversityInterest = 0.1f,
                OfficeSoftwareDemand = 0.1f

            }
        },

        SpaceCenter_Options = new List<SpaceCenterOptions>
        {
            new SpaceCenterOptions
            {
                Name = "SpaceCenter01",
                Upkeep = 480000,
                Electricityconsumption = 80000,
                Waterconsumption = 20000,
                GarbageAccumulation = 46900,
                Attractiveness = 200,
                CityAttractiveness = 0.1f,
                UniversityInterest = 0.1f,
                OfficeSoftwareDemand = 0.1f,
                IndustrialElectronicsDemand = 0.1f,
                LeisureEfficiency = 60,
                VehicleCapacity = 1,
                ProductionDuration = 0.01f

            }
        },

        PostMailbox_Options = new List<PostMailboxOptions>
        {
            new PostMailboxOptions
            {
                Name = "PostMailbox01",
                Mailcapacity = 1000,
                ComfortFactor = 0f,
                Range = 1000f,
                Capacity = 2000f,
                Magnitude = 1f

            }
        },

        RadioMast_Options = new List<RadioMastOptions>
        {
            new RadioMastOptions
            {
                Name = "RadioMast01",
                Upkeep = 5000,
                Electricityconsumption = 2500,
                Range = 1000,
                NetworkCapacity = 2000,
                NoisePollution = 2500

            },

            new RadioMastOptions
            {
                Name = "RadioMast01 Bandwidth Increase",
                Upkeep = 3000,
                Electricityconsumption = 1500,
                Range = 0,
                NetworkCapacity = 1500
             

            },

            new RadioMastOptions
            {
                Name = "RadioMast01 Wireless Network Antenna",
                Upkeep = 1500,
                Electricityconsumption = 1500,
                Range = 250,
                NetworkCapacity = 1500

            }

        },

        DeliveryTruck_Options = new List<DeliveryTruckOptions>
        {
            new DeliveryTruckOptions
            {
                Name = "CoalTruck01",
                CargoCapacity = 20000,
                CostToDrive = 150
            },

            new DeliveryTruckOptions
            {
                Name = "OilTruck01",
                CargoCapacity = 20000,
                CostToDrive = 150
            }
        },

        MaintenanceVehicles_Options = new List<MaintenanceVehiclesOptions>
        {
            new MaintenanceVehiclesOptions
            {
                Name = "ParkMaintenanceVehicle01",
                MaintenanceCapacity = 1000,
                MaintenanceRate = 200
            },

            new MaintenanceVehiclesOptions
            {
                Name = "RoadMaintenanceVehicle01",
                MaintenanceCapacity = 1000,
                MaintenanceRate = 200
            }
        },

        FireEngine_Options = new List<FireEngineOptions>
        {
            new FireEngineOptions
            {
                Name = "EU_Firetruck01",
                ExtinguishingRate = 7,
                ExtinguishingSpread = 20,
                ExtinguishingCapacity = 0,
                DestroyedClearDuration = 10
            },

            new FireEngineOptions
            {
                Name = "NA_Firetruck01",
                ExtinguishingRate = 7,
                ExtinguishingSpread = 20,
                ExtinguishingCapacity = 0,
                DestroyedClearDuration = 10
            }
        },

        PoliceCar_Options = new List<PoliceCarOptions>
        {
            new PoliceCarOptions
            {
                Name = "EU_PoliceVehicle01",
                CriminalCapacity = 2,
                CrimeReductionRate = 5000
            },

            new PoliceCarOptions
            {
                Name = "EU_PoliceVehicle02",
                CriminalCapacity = 2,
                CrimeReductionRate = 10000
            },

            new PoliceCarOptions
            {
                Name = "NA_PoliceVehicle01",
                CriminalCapacity = 2,
                CrimeReductionRate = 5000
            },

            new PoliceCarOptions
            {
                Name = "NA_PoliceVehicle02",
                CriminalCapacity = 2,
                CrimeReductionRate = 10000
            },

            new PoliceCarOptions
            {
                Name = "AdministrationVehicle01",
                CriminalCapacity = 2,
                CrimeReductionRate = 0
            }

        },

        OutsideConnection_Options = new List<OutsideConnectionOptions>
        {
            new OutsideConnectionOptions
            {
                Name = "Road Outside Connection - Twoway",
                StorageLimit = 62000000,
                StudentCapacity = 10000,
                GraduationModifier = 0,
                AmbulanceCapacity = 30,
                MedicalHelicopterCapacity = 0,
                PatientCapacity = 500,
                TreatmentBonus = 12,
                GarbageCapacity = 100000,
                GarbageVehicleCapacity = 10,
                GarbageTransportCapacity = 0,
                GarbageProcessingSpeed = 0,
                FireEngineCapacity = 10,
                FireHelicopterCapacity = 0,
                DisasterResponseCapacity = 10,
                FireVehicleEfficiency = 1,
                PolicePatrolCarCapacity = 10,
                PoliceHelicopterCapacity = 0,
                JailCapacity = 1000,
                HearseCapacity = 10,
                DeathStorageCapacity = 500,
                DeathProcessingrate = 100000,
                TaxiVehicleCapacity = 50,
                TaximaintenanceDuration = 0.007f,
                TrafficSpawnerRate = 0.3f

            }

        },


    };

    public int Version { get; set; }

    public IEnumerable<SchoolOptions> School_Options { get; set; } = new List<SchoolOptions>();
    public IEnumerable<PowerplantOptions> Powerplant_Options { get; set; } = new List<PowerplantOptions>();
    public IEnumerable<WaterpumpOptions> Waterpump_Options { get; set; } = new List <WaterpumpOptions>();
    public IEnumerable<TransformerstationOptions> Transformerstation_Options { get; set; } = new List<TransformerstationOptions> ();
    public IEnumerable<ServerfarmOptions> Serverfarm_Options { get; set; } = new List<ServerfarmOptions>();
    public IEnumerable<GarbagetruckOptions> Garbagetruck_Options { get; set; } = new List<GarbagetruckOptions>();
    public IEnumerable<TransportbusOptions> Transportbus_Options { get; set; } = new List<TransportbusOptions>();
    public IEnumerable<ParkinghallOptions> Parkinghall_Options { get; set; } = new List<ParkinghallOptions>();
    public IEnumerable<CityparkOptions> Citypark_Options { get; set; } = new List<CityparkOptions>();
    public IEnumerable<WastewaterOptions> Wastewater_Options { get; set; } = new List<WastewaterOptions>();
    public IEnumerable<IncinerationPlantOptions> IncinerationPlant_Options { get; set; } = new List<IncinerationPlantOptions>();
    public IEnumerable<HealthcareOptions> Healthcare_Options { get; set; } = new List<HealthcareOptions>();
    public IEnumerable<PostofficeOptions> Postoffice_Options { get; set; } = new List<PostofficeOptions>();
    public IEnumerable<CemeteryOptions> Cemetery_Options { get; set; } = new List<CemeteryOptions>();
    public IEnumerable<CrematoriumOptions> Crematorium_Options { get; set; } = new List<CrematoriumOptions>();
    public IEnumerable<WindturbineOptions> Windturbine_Options { get; set; } = new List<WindturbineOptions>();
    public IEnumerable<EmergencybatteryOptions> Emergencybattery_Options { get; set; } = new List<EmergencybatteryOptions>();
    public IEnumerable<GeothermalpowerplantOptions> Geothermalpowerplant_Options { get; set; } = new List<GeothermalpowerplantOptions>();
    public IEnumerable<SolarpowerstationOptions> Solarpowerstation_Options { get; set; } = new List<SolarpowerstationOptions>();
    public IEnumerable<SignatureResidentialbuildingOptions> SignatureResidentialbuilding_Options { get; set; } = new List<SignatureResidentialbuildingOptions>();
    public IEnumerable<SignatureCommercialbuildingOptions> SignatureCommercialbuilding_Options { get; set; } = new List<SignatureCommercialbuildingOptions>();
    public IEnumerable<PostVanOptions> PostVan_Options { get; set; } = new List<PostVanOptions>();
    public IEnumerable<SignatureOfficebuildingOptions> SignatureOfficebuilding_Options { get; set; } = new List<SignatureOfficebuildingOptions>();
    public IEnumerable<SignatureMixedbuildingOptions> SignatureMixedbuilding_Options { get; set; } = new List<SignatureMixedbuildingOptions>();
    public IEnumerable<FireStationOptions> FireStation_Options { get; set; } = new List<FireStationOptions>();
    public IEnumerable<FireHelicopterDepotOptions> FireHelicopterDepot_Options { get; set; } = new List<FireHelicopterDepotOptions>();
    public IEnumerable<FirewatchTowerOptions> FirewatchTower_Options { get; set; } = new List<FirewatchTowerOptions>();
    public IEnumerable<PoliceStationOptions> PoliceStation_Options { get; set; } = new List<PoliceStationOptions>();
    public IEnumerable<PrisonOptions> Prison_Options { get; set; } = new List<PrisonOptions>();
    public IEnumerable<DiseaseControlCenterOptions> DiseaseControlCenter_Options { get; set; } = new List<DiseaseControlCenterOptions>();
    public IEnumerable<HeathResearchInstituteOptions> HeathResearchInstitute_Options { get; set; } = new List<HeathResearchInstituteOptions>();
    public IEnumerable<RadioTelescopeOptions> RadioTelescope_Options { get; set; } = new List<RadioTelescopeOptions>();
    public IEnumerable<GeologicalResearchCenterOptions> GeologicalResearchCenter_Options { get; set; } = new List<GeologicalResearchCenterOptions>();
    public IEnumerable<TechnicalUniversityOptions> TechnicalUniversity_Options { get; set; } = new List<TechnicalUniversityOptions>();
    public IEnumerable<EarlyDisasterWarningSystemOptions> EarlyDisasterWarningSystem_Options { get; set; } = new List<EarlyDisasterWarningSystemOptions>();
    public IEnumerable<WelfareOfficeOptions> WelfareOffice_Options { get; set; } = new List<WelfareOfficeOptions>();
    public IEnumerable<CityHallOptions> CityHall_Options { get; set; } = new List<CityHallOptions>();
    public IEnumerable<LargeEmergencyShelterOptions> LargeEmergencyShelter_Options { get; set; } = new List<LargeEmergencyShelterOptions>();
    public IEnumerable<CentralBankOptions> CentralBank_Options { get; set; } = new List<CentralBankOptions>();
    public IEnumerable<MedicalUniversityOptions> MedicalUniversity_Options { get; set; } = new List<MedicalUniversityOptions>();
    public IEnumerable<LargeHadronColliderOptions> LargeHadronCollider_Options { get; set; } = new List<LargeHadronColliderOptions>();
    public IEnumerable<PublicTransportStopsOptions> PublicTransportStops_Options { get; set; } = new List<PublicTransportStopsOptions>();
    public IEnumerable<PublicTransportDepotsOptions> PublicTransportDepots_Options { get; set; } = new List<PublicTransportDepotsOptions>();
    public IEnumerable<PublicTransportStationsOptions> PublicTransportStations_Options { get; set; } = new List<PublicTransportStationsOptions>();
    public IEnumerable<AirportOptions> Airport_Options { get; set; } = new List<AirportOptions>();
    public IEnumerable<SpaceCenterOptions> SpaceCenter_Options { get; set; } = new List<SpaceCenterOptions>();
    public IEnumerable<PostMailboxOptions> PostMailbox_Options { get; set; } = new List<PostMailboxOptions>();
    public IEnumerable<RadioMastOptions> RadioMast_Options { get; set; } = new List<RadioMastOptions>();
    public IEnumerable<DeliveryTruckOptions> DeliveryTruck_Options { get; set; } = new List<DeliveryTruckOptions>();
    public IEnumerable<MaintenanceVehiclesOptions> MaintenanceVehicles_Options { get; set; } = new List<MaintenanceVehiclesOptions>();
    public IEnumerable<FireEngineOptions> FireEngine_Options { get; set; } = new List<FireEngineOptions>();
    public IEnumerable<PoliceCarOptions> PoliceCar_Options { get; set; } = new List<PoliceCarOptions>();
    public IEnumerable<OutsideConnectionOptions> OutsideConnection_Options { get; set; } = new List<OutsideConnectionOptions>();


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
    public IReadOnlyDictionary<string, PoliceStationOptions> GetPoliceStationDictionary()
    {
        var PoliceStationdict = new Dictionary<string, PoliceStationOptions>();
        foreach (var PoliceStation_option in PoliceStation_Options)
        {
            PoliceStationdict.Add(PoliceStation_option.Name, PoliceStation_option);
        }
        return PoliceStationdict;
    }
    public IReadOnlyDictionary<string, PrisonOptions> GetPrisonDictionary()
    {
        var Prisondict = new Dictionary<string, PrisonOptions>();
        foreach (var Prison_option in Prison_Options)
        {
            Prisondict.Add(Prison_option.Name, Prison_option);
        }
        return Prisondict;
    }
    public IReadOnlyDictionary<string, DiseaseControlCenterOptions> GetDiseaseControlCenterDictionary()
    {
        var DiseaseControlCenterdict = new Dictionary<string, DiseaseControlCenterOptions>();
        foreach (var DiseaseControlCenter_option in DiseaseControlCenter_Options)
        {
            DiseaseControlCenterdict.Add(DiseaseControlCenter_option.Name, DiseaseControlCenter_option);
        }
        return DiseaseControlCenterdict;
    }
    public IReadOnlyDictionary<string, HeathResearchInstituteOptions> GetHeathResearchInstituteDictionary()
    {
        var HeathResearchInstitutedict = new Dictionary<string, HeathResearchInstituteOptions>();
        foreach (var HeathResearchInstitute_option in HeathResearchInstitute_Options)
        {
            HeathResearchInstitutedict.Add(HeathResearchInstitute_option.Name, HeathResearchInstitute_option);
        }
        return HeathResearchInstitutedict;
    }
    public IReadOnlyDictionary<string, RadioTelescopeOptions> GetRadioTelescopeDictionary()
    {
        var RadioTelescopedict = new Dictionary<string, RadioTelescopeOptions>();
        foreach (var RadioTelescope_option in RadioTelescope_Options)
        {
            RadioTelescopedict.Add(RadioTelescope_option.Name, RadioTelescope_option);
        }
        return RadioTelescopedict;
    }
    public IReadOnlyDictionary<string, GeologicalResearchCenterOptions> GetGeologicalResearchCenterDictionary()
    {
        var GeologicalResearchCenterdict = new Dictionary<string, GeologicalResearchCenterOptions>();
        foreach (var GeologicalResearchCenter_option in GeologicalResearchCenter_Options)
        {
            GeologicalResearchCenterdict.Add(GeologicalResearchCenter_option.Name, GeologicalResearchCenter_option);
        }
        return GeologicalResearchCenterdict;
    }
    public IReadOnlyDictionary<string, TechnicalUniversityOptions> GetTechnicalUniversityDictionary()
    {
        var TechnicalUniversitydict = new Dictionary<string, TechnicalUniversityOptions>();
        foreach (var TechnicalUniversity_option in TechnicalUniversity_Options)
        {
            TechnicalUniversitydict.Add(TechnicalUniversity_option.Name, TechnicalUniversity_option);
        }
        return TechnicalUniversitydict;
    }
    public IReadOnlyDictionary<string, EarlyDisasterWarningSystemOptions> GetEarlyDisasterWarningSystemDictionary()
    {
        var EarlyDisasterWarningSystemdict = new Dictionary<string, EarlyDisasterWarningSystemOptions>();
        foreach (var EarlyDisasterWarningSystem_option in EarlyDisasterWarningSystem_Options)
        {
            EarlyDisasterWarningSystemdict.Add(EarlyDisasterWarningSystem_option.Name, EarlyDisasterWarningSystem_option);
        }
        return EarlyDisasterWarningSystemdict;
    }
    public IReadOnlyDictionary<string, WelfareOfficeOptions> GetWelfareOfficeDictionary()
    {
        var WelfareOfficedict = new Dictionary<string, WelfareOfficeOptions>();
        foreach (var WelfareOffice_option in WelfareOffice_Options)
        {
            WelfareOfficedict.Add(WelfareOffice_option.Name, WelfareOffice_option);
        }
        return WelfareOfficedict;
    }
    public IReadOnlyDictionary<string, CityHallOptions> GetCityHallDictionary()
    {
        var CityHalldict = new Dictionary<string, CityHallOptions>();
        foreach (var CityHall_option in CityHall_Options)
        {
            CityHalldict.Add(CityHall_option.Name, CityHall_option);
        }
        return CityHalldict;
    }
    public IReadOnlyDictionary<string, LargeEmergencyShelterOptions> GetLargeEmergencyShelterDictionary()
    {
        var LargeEmergencyShelterdict = new Dictionary<string, LargeEmergencyShelterOptions>();
        foreach (var LargeEmergencyShelter_option in LargeEmergencyShelter_Options)
        {
            LargeEmergencyShelterdict.Add(LargeEmergencyShelter_option.Name, LargeEmergencyShelter_option);
        }
        return LargeEmergencyShelterdict;
    }
    public IReadOnlyDictionary<string, CentralBankOptions> GetCentralBankDictionary()
    {
        var CentralBankdict = new Dictionary<string, CentralBankOptions>();
        foreach (var CentralBank_option in CentralBank_Options)
        {
            CentralBankdict.Add(CentralBank_option.Name, CentralBank_option);
        }
        return CentralBankdict;
    }
    public IReadOnlyDictionary<string, MedicalUniversityOptions> GetMedicalUniversityDictionary()
    {
        var MedicalUniversitydict = new Dictionary<string, MedicalUniversityOptions>();
        foreach (var MedicalUniversity_option in MedicalUniversity_Options)
        {
            MedicalUniversitydict.Add(MedicalUniversity_option.Name, MedicalUniversity_option);
        }
        return MedicalUniversitydict;
    }
    public IReadOnlyDictionary<string, LargeHadronColliderOptions> GetLargeHadronColliderDictionary()
    {
        var LargeHadronColliderdict = new Dictionary<string, LargeHadronColliderOptions>();
        foreach (var LargeHadronCollider_option in LargeHadronCollider_Options)
        {
            LargeHadronColliderdict.Add(LargeHadronCollider_option.Name, LargeHadronCollider_option);
        }
        return LargeHadronColliderdict;
    }
    public IReadOnlyDictionary<string, PublicTransportStopsOptions> GetPublicTransportStopsDictionary()
    {
        var PublicTransportStopsdict = new Dictionary<string, PublicTransportStopsOptions>();
        foreach (var PublicTransportStops_option in PublicTransportStops_Options)
        {
            PublicTransportStopsdict.Add(PublicTransportStops_option.Name, PublicTransportStops_option);
        }
        return PublicTransportStopsdict;
    }
    public IReadOnlyDictionary<string, PublicTransportDepotsOptions> GetPublicTransportDepotsDictionary()
    {
        var PublicTransportDepotsdict = new Dictionary<string, PublicTransportDepotsOptions>();
        foreach (var PublicTransportDepots_option in PublicTransportDepots_Options)
        {
            PublicTransportDepotsdict.Add(PublicTransportDepots_option.Name, PublicTransportDepots_option);
        }
        return PublicTransportDepotsdict;
    }
    public IReadOnlyDictionary<string, PublicTransportStationsOptions> GetPublicTransportStationsDictionary()
    {
        var PublicTransportStationsdict = new Dictionary<string, PublicTransportStationsOptions>();
        foreach (var PublicTransportStations_option in PublicTransportStations_Options)
        {
            PublicTransportStationsdict.Add(PublicTransportStations_option.Name, PublicTransportStations_option);
        }
        return PublicTransportStationsdict;
    }
    public IReadOnlyDictionary<string, AirportOptions> GetAirportDictionary()
    {
        var Airportdict = new Dictionary<string, AirportOptions>();
        foreach (var Airport_option in Airport_Options)
        {
            Airportdict.Add(Airport_option.Name, Airport_option);
        }
        return Airportdict;
    }
    public IReadOnlyDictionary<string, SpaceCenterOptions> GetSpaceCenterDictionary()
    {
        var SpaceCenterdict = new Dictionary<string, SpaceCenterOptions>();
        foreach (var SpaceCenter_option in SpaceCenter_Options)
        {
            SpaceCenterdict.Add(SpaceCenter_option.Name, SpaceCenter_option);
        }
        return SpaceCenterdict;
    }
    public IReadOnlyDictionary<string, PostMailboxOptions> GetPostMailboxDictionary()
    {
        var PostMailboxdict = new Dictionary<string, PostMailboxOptions>();
        foreach (var PostMailbox_option in PostMailbox_Options)
        {
            PostMailboxdict.Add(PostMailbox_option.Name, PostMailbox_option);
        }
        return PostMailboxdict;
    }
    public IReadOnlyDictionary<string, RadioMastOptions> GetRadioMastDictionary()
    {
        var RadioMastdict = new Dictionary<string, RadioMastOptions>();
        foreach (var RadioMast_option in RadioMast_Options)
        {
            RadioMastdict.Add(RadioMast_option.Name, RadioMast_option);
        }
        return RadioMastdict;
    }
    public IReadOnlyDictionary<string, DeliveryTruckOptions> GetDeliveryTruckDictionary()
    {
        var DeliveryTruckdict = new Dictionary<string, DeliveryTruckOptions>();
        foreach (var DeliveryTruck_option in DeliveryTruck_Options)
        {
            DeliveryTruckdict.Add(DeliveryTruck_option.Name, DeliveryTruck_option);
        }
        return DeliveryTruckdict;
    }
    public IReadOnlyDictionary<string, MaintenanceVehiclesOptions> GetMaintenanceVehiclesDictionary()
    {
        var MaintenanceVehiclesdict = new Dictionary<string, MaintenanceVehiclesOptions>();
        foreach (var MaintenanceVehicles_option in MaintenanceVehicles_Options)
        {
            MaintenanceVehiclesdict.Add(MaintenanceVehicles_option.Name, MaintenanceVehicles_option);
        }
        return MaintenanceVehiclesdict;
    }
    public IReadOnlyDictionary<string, FireEngineOptions> GetFireEngineDictionary()
    {
        var FireEnginedict = new Dictionary<string, FireEngineOptions>();
        foreach (var FireEngine_option in FireEngine_Options)
        {
            FireEnginedict.Add(FireEngine_option.Name, FireEngine_option);
        }
        return FireEnginedict;
    }
    public IReadOnlyDictionary<string, PoliceCarOptions> GetPoliceCarDictionary()
    {
        var PoliceCardict = new Dictionary<string, PoliceCarOptions>();
        foreach (var PoliceCar_option in PoliceCar_Options)
        {
            PoliceCardict.Add(PoliceCar_option.Name, PoliceCar_option);
        }
        return PoliceCardict;
    }

    public IReadOnlyDictionary<string, OutsideConnectionOptions> GetOutsideConnectionDictionary()
    {
        var OutsideConnectiondict = new Dictionary<string, OutsideConnectionOptions>();
        foreach (var OutsideConnection_option in OutsideConnection_Options)
        {
            OutsideConnectiondict.Add(OutsideConnection_option.Name, OutsideConnection_option);
        }
        return OutsideConnectiondict;
    }




    public void RemoveBadEntires()
    {
         School_Options = School_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) && 
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
            x.Storage >= 0 &&
            x.Production >= 0);

        
        Waterpump_Options = Waterpump_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Capacity >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.ElectricityConsumption >= 0 &&
            x.Purification >= 0 &&
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
            x.CityEntertainment >= 0 &&
            x.CityTelecomCapacity >= 0 &&
            x.CityAttractiveness >= 0 &&
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
            x.ElectricityConsumption >= 0 &&
            x.WaterConsumption >= 0 &&
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
            x.SortingRate >= 0 &&
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

        PoliceStation_Options = PoliceStation_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.ElectricityConsumption >= 0 &&
            x.WaterConsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.PatrolCarCapacity >= 0 &&
            x.PoliceHelicopterCapacity >= 0 &&
            x.JailCapacity >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0 &&
            x.Noisepollution >= 0);

        Prison_Options = Prison_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.PrisonVanCapacity >= 0 &&
            x.PrisonerCapacity >= 0 &&
            x.CrimeAccumulation <= 0 &&
            x.CrimeAccumlationRadius >= 0 &&
            x.NoisePollution >= 0);

        DiseaseControlCenter_Options = DiseaseControlCenter_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.AmbulanceCapacity >= 0 &&
            x.MedicalHelicopterCapacity >= 0 &&
            x.PatientCapacity >= 0 &&
            x.TreatmentBonus >= 0 &&
            x.CityDiseaseprobability <= 0 &&
            x.CityPollutionhealthAffect <= 0);

        HeathResearchInstitute_Options = HeathResearchInstitute_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.CityDiseaseprobability <= 0 &&
            x.CityParkEntertainment >= 0);

        RadioTelescope_Options = RadioTelescope_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.CityUniversityGraduation >= 0);

        GeologicalResearchCenter_Options = GeologicalResearchCenter_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Noisepollution >= 0 &&
            x.CityOreResourceAmmount >= 0 &&
            x.CityOilResourceAmmount >= 0 &&
            x.CityCollegegraduation >= 0);

        TechnicalUniversity_Options = TechnicalUniversity_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.StudentCapacity >= 0 &&
            x.NoisePollution >= 0 &&
            x.CityIndustrialEfficiency >= 0 &&
            x.CityOfficeEfficiency >= 0);

        EarlyDisasterWarningSystem_Options = EarlyDisasterWarningSystem_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.CityDisasterWarningTime >= 0 &&
            x.CityDisasterDamageRate <= 0);

        WelfareOffice_Options = WelfareOffice_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0 &&
            x.NoisePollution >= 0);

        CityHall_Options = CityHall_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.CityLoanIntrest <= 0 &&
            x.CityImportCost <= 0);

        LargeEmergencyShelter_Options = LargeEmergencyShelter_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.ShelterCapacity >= 0 &&
            x.VehicleCapacity >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0);

        CentralBank_Options = CentralBank_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.CityLoanIntrest <= 0 &&
            x.CityImportCost <= 0 &&
            x.CityExportCost >= 0);

        MedicalUniversity_Options = MedicalUniversity_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.StudentCapacity >= 0 &&
            x.NoisePollution >= 0 &&
            x.CityRecoverFailChange <= 0 &&
            x.CityHospitalEfficiency >= 0);

        LargeHadronCollider_Options = LargeHadronCollider_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.CityUniversityInterest >= 0 &&
            x.CityOfficeSoftwareDemand >= 0 &&
            x.CityIndustrialElectronicDemand >= 0 &&
            x.CityOfficeSoftwareEfficiency >= 0 &&
            x.CityIndustrialElectronicEfficiency >= 0);

        PublicTransportStops_Options = PublicTransportStops_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.EnterDistance >= 0 &&
            x.ExitDistance >= 0 &&
            x.AccessDistance >= 0 &&
            x.BoardingTime >= 0 &&
            x.ComfortFactor >= 0 &&
            x.LoadingFactor >= 0);

        PublicTransportDepots_Options = PublicTransportDepots_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.AirPollution >= 0 &&
            x.NoisePollution >= 0 &&
            x.VehicleCapacity >= 0 &&
            x.MaintenanceDuration >= 0);

        PublicTransportStations_Options = PublicTransportStations_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.NoisePollution >= 0 &&
            x.StorageLimit >= 0 &&
            x.Transports >= 0 &&
            x.ComfortFactor >= 0);

        Airport_Options = Airport_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.StorageLimit >= 0 &&
            x.Transports >= 0 &&
            x.ComfortFactor >= 0 &&
            x.Attractiveness >= 0 &&
            x.OfficeEfficiency >= 0 &&
            x.UniversityInterest >= 0 &&
            x.OfficeSoftwareDemand >= 0);

        SpaceCenter_Options = SpaceCenter_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Attractiveness >= 0 &&
            x.CityAttractiveness >= 0 &&
            x.UniversityInterest >= 0 &&
            x.IndustrialElectronicsDemand >= 0 &&
            x.OfficeSoftwareDemand >= 0 &&
            x.VehicleCapacity >= 0 &&
            x.ProductionDuration >= 0 &&
            x.LeisureEfficiency >= 0);

        PostMailbox_Options = PostMailbox_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Mailcapacity >= 0 &&
            x.ComfortFactor >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.Magnitude >= 0);

        RadioMast_Options = RadioMast_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Upkeep >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Range >= 0 &&
            x.NetworkCapacity >= 0 &&
            x.NoisePollution >= 0);

        DeliveryTruck_Options = DeliveryTruck_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.CargoCapacity >= 0 &&
            x.CostToDrive >= 0);

        MaintenanceVehicles_Options = MaintenanceVehicles_Options.Where(
        x => !string.IsNullOrEmpty(x.Name) &&
        x.MaintenanceCapacity >= 0 &&
        x.MaintenanceRate >= 0);

        FireEngine_Options = FireEngine_Options.Where(
        x => !string.IsNullOrEmpty(x.Name) &&
        x.ExtinguishingRate >= 0 &&
        x.ExtinguishingSpread >= 0 &&
        x.ExtinguishingCapacity >= 0 &&
        x.DestroyedClearDuration >= 0);

        PoliceCar_Options = PoliceCar_Options.Where(
        x => !string.IsNullOrEmpty(x.Name) &&
        x.CriminalCapacity >= 0 &&
        x.CrimeReductionRate >= 0);

        OutsideConnection_Options = OutsideConnection_Options.Where(
        x => !string.IsNullOrEmpty(x.Name) &&
        x.StorageLimit >= 0 &&
        x.StudentCapacity >= 0 &&
        x.GraduationModifier >= 0 &&
        x.AmbulanceCapacity >= 0 &&
        x.MedicalHelicopterCapacity >= 0 &&
        x.PatientCapacity >= 0 &&
        x.TreatmentBonus >= 0 &&
        x.GarbageCapacity >= 0 &&
        x.GarbageVehicleCapacity >= 0 &&
        x.GarbageTransportCapacity >= 0 &&
        x.GarbageProcessingSpeed >= 0 &&
        x.FireEngineCapacity >= 0 &&
        x.FireHelicopterCapacity >= 0 &&
        x.DisasterResponseCapacity >= 0 &&
        x.PolicePatrolCarCapacity >= 0 &&
        x.PoliceHelicopterCapacity >= 0 &&
        x.JailCapacity >= 0 &&
        x.HearseCapacity >= 0 &&
        x.DeathStorageCapacity >= 0 &&
        x.DeathProcessingrate >= 0 &&
        x.TaxiVehicleCapacity >= 0 &&
        x.TaximaintenanceDuration >= 0 &&
        x.TrafficSpawnerRate >= 0);


    }

    public int UpdateToLatestVersion()
    {
        var initialVersion = Version;
        if (Version == 323)
        {
                if (!Wastewater_Options.Any(o => o.Name == "SewageOutlet01 Chemical Purification"))
                Wastewater_Options = Wastewater_Options.Append(new WastewaterOptions
                {
                    Name = "SewageOutlet01 Chemical Purification",
                    UpkeepCost = 4000,
                    Capacity = 0,
                    Purification = 0.25f,
                    GarbageAccumulation = 0,
                    GroundPollution = 0,
                    AirPollution = 2500,
                    NoisePollution = 5000,
                    ElectricityConsumption = 0

                });

            if (!Wastewater_Options.Any(o => o.Name == "SewageOutlet01 Extra Settling Tank"))
                Wastewater_Options = Wastewater_Options.Append(new WastewaterOptions
                {
                    Name = "SewageOutlet01 Extra Settling Tank",
                    UpkeepCost = 10000,
                    Capacity = 0,
                    Purification = 0.1f,
                    GarbageAccumulation = 0,
                    GroundPollution = 2500,
                    AirPollution = 2500,
                    NoisePollution = 5000,
                    ElectricityConsumption = 0

                });

            if (!Wastewater_Options.Any(o => o.Name == "WastewaterTreatmentPlant01 Advanced Filtering System"))
                Wastewater_Options = Wastewater_Options.Append(new WastewaterOptions
                {
                    Name = "WastewaterTreatmentPlant01 Advanced Filtering System",
                    UpkeepCost = 20000,
                    Capacity = 0,
                    Purification = 0.1f,
                    GarbageAccumulation = 12500,
                    GroundPollution = 0,
                    AirPollution = 0,
                    NoisePollution = 0,
                    ElectricityConsumption = 2000

                });

            if (!Wastewater_Options.Any(o => o.Name == "WastewaterTreatmentPlant01 Extra Processing Unit"))
                Wastewater_Options = Wastewater_Options.Append(new WastewaterOptions
                {
                    Name = "WastewaterTreatmentPlant01 Extra Processing Unit",
                    UpkeepCost = 40000,
                    Capacity = 100000,
                    Purification = 0f,
                    GarbageAccumulation = 10000,
                    GroundPollution = 2500,
                    AirPollution = 2500,
                    NoisePollution = 7500,
                    ElectricityConsumption = 1000

                });

            if (!Parkinghall_Options.Any(o => o.Name == "ParkingLot01"))
                Parkinghall_Options = Parkinghall_Options.Append(new ParkinghallOptions
                {
                    Name = "ParkingLot01",
                    Upkeep = 2200,
                    GarageCapacity = 0,
                    Comfortfactor = 0.5f,
                    Electricityconsumption = 200,
                    Waterconsumption = 0,
                    GarbageAccumulation = 200,
                    Noisepollution = 2500

                });

            if (!Parkinghall_Options.Any(o => o.Name == "ParkingLot02"))
                Parkinghall_Options = Parkinghall_Options.Append(new ParkinghallOptions
                {
                    Name = "ParkingLot02",
                    Upkeep = 3000,
                    GarageCapacity = 0,
                    Comfortfactor = 0.5f,
                    Electricityconsumption = 300,
                    Waterconsumption = 0,
                    GarbageAccumulation = 300,
                    Noisepollution = 2500

                });

            if (!Parkinghall_Options.Any(o => o.Name == "ParkingLot03"))
                Parkinghall_Options = Parkinghall_Options.Append(new ParkinghallOptions
                {
                    Name = "ParkingLot03",
                    Upkeep = 7000,
                    GarageCapacity = 0,
                    Comfortfactor = 0.5f,
                    Electricityconsumption = 700,
                    Waterconsumption = 0,
                    GarbageAccumulation = 700,
                    Noisepollution = 5000

                });

            if (!Parkinghall_Options.Any(o => o.Name == "ParkingLot04"))
                Parkinghall_Options = Parkinghall_Options.Append(new ParkinghallOptions
                {
                    Name = "ParkingLot04",
                    Upkeep = 16000,
                    GarageCapacity = 0,
                    Comfortfactor = 0.5f,
                    Electricityconsumption = 1600,
                    Waterconsumption = 0,
                    GarbageAccumulation = 1700,
                    Noisepollution = 5000

                });

            if (!Parkinghall_Options.Any(o => o.Name == "ParkingHall01 Car Wash"))
                Parkinghall_Options = Parkinghall_Options.Append(new ParkinghallOptions
                {
                    Name = "ParkingHall01 Car Wash",
                    Upkeep = 5000,
                    GarageCapacity = 0,
                    Comfortfactor = 0.1f,
                    Electricityconsumption = 2400,
                    Waterconsumption = 2000,
                    GarbageAccumulation = 1600

                });

            if (!Parkinghall_Options.Any(o => o.Name == "AutomatedParkingBuilding01"))
                Parkinghall_Options = Parkinghall_Options.Append(new ParkinghallOptions
                {
                    Name = "AutomatedParkingBuilding01",
                    Upkeep = 130000,
                    GarageCapacity = 416,
                    Comfortfactor = 0.750f,
                    Electricityconsumption = 7000,
                    Waterconsumption = 3000,
                    GarbageAccumulation = 2500,
                    Noisepollution = 2500

                });


            Wastewater_Options = Wastewater_Options.OrderBy(x => x.Name);
            Parkinghall_Options = Parkinghall_Options.OrderBy(x => x.Name);


            Version = 324;
        }
        if (Version == 324)
        {
            if (!Healthcare_Options.Any(o => o.Name == "MedicalClinic01 Ambulance Depot"))
                Healthcare_Options = Healthcare_Options.Append(new HealthcareOptions
                {
                    Name = "MedicalClinic01 Ambulance Depot",
                    UpkeepCost = 7000,
                    Waterconsumption = 250,
                    Electricityconsumption = 500,
                    GarbageAccumulation = 400,
                    Ambulancecapacity = 5,
                    Helicoptercapacity = 0,
                    Patientcapacity = 0,
                    Treatmentbonus = 0

                });

            if (!Healthcare_Options.Any(o => o.Name == "MedicalClinic01 Extention Wing"))
                Healthcare_Options = Healthcare_Options.Append(new HealthcareOptions
                {
                    Name = "MedicalClinic01 Extention Wing",
                    UpkeepCost = 25000,
                    Waterconsumption = 500,
                    Electricityconsumption = 1000,
                    GarbageAccumulation = 700,
                    Ambulancecapacity = 0,
                    Helicoptercapacity = 0,
                    Patientcapacity = 25,
                    Treatmentbonus = 0

                });

            if (!Healthcare_Options.Any(o => o.Name == "Hospital01 Helipad"))
                Healthcare_Options = Healthcare_Options.Append(new HealthcareOptions
                {
                    Name = "Hospital01 Helipad",
                    UpkeepCost = 35000,
                    Waterconsumption = 250,
                    Electricityconsumption = 1000,
                    GarbageAccumulation = 1000,
                    Ambulancecapacity = 0,
                    Helicoptercapacity = 1,
                    Patientcapacity = 0,
                    Treatmentbonus = 0

                });

            if (!Healthcare_Options.Any(o => o.Name == "Hospital01 Special Ward"))
                Healthcare_Options = Healthcare_Options.Append(new HealthcareOptions
                {
                    Name = "Hospital01 Special Ward",
                    UpkeepCost = 100000,
                    Waterconsumption = 2500,
                    Electricityconsumption = 2000,
                    GarbageAccumulation = 3200,
                    Ambulancecapacity = 0,
                    Helicoptercapacity = 0,
                    Patientcapacity = 0,
                    Treatmentbonus = 0

                });

            if (!Healthcare_Options.Any(o => o.Name == "Hospital01 Trauma Center"))
                Healthcare_Options = Healthcare_Options.Append(new HealthcareOptions
                {
                    Name = "Hospital01 Trauma Center",
                    UpkeepCost = 80000,
                    Waterconsumption = 2500,
                    Electricityconsumption = 2000,
                    GarbageAccumulation = 3200,
                    Ambulancecapacity = 0,
                    Helicoptercapacity = 0,
                    Patientcapacity = 0,
                    Treatmentbonus = 15

                });

            if (!DeliveryTruck_Options.Any(o => o.Name == "CoalTruck01"))
                DeliveryTruck_Options = DeliveryTruck_Options.Append(new DeliveryTruckOptions
                {
                    Name = "CoalTruck01",
                    CargoCapacity = 20000,
                    CostToDrive = 150

                });

            if (!DeliveryTruck_Options.Any(o => o.Name == "OilTruck01"))
                DeliveryTruck_Options = DeliveryTruck_Options.Append(new DeliveryTruckOptions
                {
                    Name = "OilTruck01",
                    CargoCapacity = 20000,
                    CostToDrive = 150

                });

            if (!MaintenanceVehicles_Options.Any(o => o.Name == "ParkMaintenanceVehicle01"))
                MaintenanceVehicles_Options = MaintenanceVehicles_Options.Append(new MaintenanceVehiclesOptions
                {
                    Name = "ParkMaintenanceVehicle01",
                    MaintenanceCapacity = 1000,
                    MaintenanceRate = 200

                });

            if (!MaintenanceVehicles_Options.Any(o => o.Name == "RoadMaintenanceVehicle01"))
                MaintenanceVehicles_Options = MaintenanceVehicles_Options.Append(new MaintenanceVehiclesOptions
                {
                    Name = "RoadMaintenanceVehicle01",
                    MaintenanceCapacity = 1000,
                    MaintenanceRate = 200

                });

            if (!FireEngine_Options.Any(o => o.Name == "EU_Firetruck01"))
                FireEngine_Options = FireEngine_Options.Append(new FireEngineOptions
                {
                    Name = "EU_Firetruck01",
                    ExtinguishingRate = 7,
                    ExtinguishingSpread = 20,
                    ExtinguishingCapacity = 0,
                    DestroyedClearDuration = 10

                });

            if (!FireEngine_Options.Any(o => o.Name == "NA_Firetruck01"))
                FireEngine_Options = FireEngine_Options.Append(new FireEngineOptions
                {
                    Name = "NA_Firetruck01",
                    ExtinguishingRate = 7,
                    ExtinguishingSpread = 20,
                    ExtinguishingCapacity = 0,
                    DestroyedClearDuration = 10

                });

            if (!PoliceCar_Options.Any(o => o.Name == "EU_PoliceVehicle01"))
                PoliceCar_Options = PoliceCar_Options.Append(new PoliceCarOptions
                {
                    Name = "EU_PoliceVehicle01",
                    CriminalCapacity = 2,
                    CrimeReductionRate = 5000

                });

            if (!PoliceCar_Options.Any(o => o.Name == "EU_PoliceVehicle02"))
                PoliceCar_Options = PoliceCar_Options.Append(new PoliceCarOptions
                {
                    Name = "EU_PoliceVehicle02",
                    CriminalCapacity = 2,
                    CrimeReductionRate = 10000

                });

            if (!PoliceCar_Options.Any(o => o.Name == "NA_PoliceVehicle01"))
                PoliceCar_Options = PoliceCar_Options.Append(new PoliceCarOptions
                {
                    Name = "NA_PoliceVehicle01",
                    CriminalCapacity = 2,
                    CrimeReductionRate = 5000

                });

            if (!PoliceCar_Options.Any(o => o.Name == "NA_PoliceVehicle02"))
                PoliceCar_Options = PoliceCar_Options.Append(new PoliceCarOptions
                {
                    Name = "NA_PoliceVehicle02",
                    CriminalCapacity = 2,
                    CrimeReductionRate = 10000

                });

            if (!PoliceCar_Options.Any(o => o.Name == "AdministrationVehicle01"))
                PoliceCar_Options = PoliceCar_Options.Append(new PoliceCarOptions
                {
                    Name = "AdministrationVehicle01",
                    CriminalCapacity = 2,
                    CrimeReductionRate = 0

                });

            if (!OutsideConnection_Options.Any(o => o.Name == "Road Outside Connection - Twoway"))
                OutsideConnection_Options = OutsideConnection_Options.Append(new OutsideConnectionOptions
                {
                    Name = "Road Outside Connection - Twoway",
                    StorageLimit = 62000000,
                    StudentCapacity = 10000,
                    GraduationModifier = 0f,
                    AmbulanceCapacity = 30,
                    MedicalHelicopterCapacity = 0,
                    PatientCapacity = 500,
                    TreatmentBonus = 12,
                    GarbageCapacity = 100000,
                    GarbageVehicleCapacity = 10,
                    GarbageTransportCapacity = 0,
                    GarbageProcessingSpeed = 0,
                    FireEngineCapacity = 10,
                    FireHelicopterCapacity = 0,
                    DisasterResponseCapacity = 10,
                    FireVehicleEfficiency = 1f,
                    PolicePatrolCarCapacity = 10,
                    PoliceHelicopterCapacity = 0,
                    JailCapacity = 1000,
                    HearseCapacity = 10,
                    DeathStorageCapacity = 500,
                    DeathProcessingrate = 100000f,
                    TaxiVehicleCapacity = 50,
                    TaximaintenanceDuration = 0.007f,
                    TrafficSpawnerRate = 0.3f

                });

            Healthcare_Options = Healthcare_Options.OrderBy(x => x.Name);
            DeliveryTruck_Options = DeliveryTruck_Options.OrderBy(x => x.Name);
            MaintenanceVehicles_Options = MaintenanceVehicles_Options.OrderBy(x => x.Name);
            FireEngine_Options = FireEngine_Options.OrderBy(x => x.Name);
            PoliceCar_Options = PoliceCar_Options.OrderBy(x => x.Name);
            OutsideConnection_Options = OutsideConnection_Options.OrderBy(x => x.Name);

            Version = 325;
        }

        return Version - initialVersion;

    }
    
}