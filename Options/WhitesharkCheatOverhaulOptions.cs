using Game.Simulation;
using Game.UI.InGame;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.InputSystem.Utilities;

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
                UpkeepCost = 50,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                GarbageAccumulation = 0,
                Waterconsumption = 0,
                Electricityconsumption = 0
            },
            new SchoolOptions
            {
                Name = "HighSchool01",
                UpkeepCost = 50,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                GarbageAccumulation = 0,
                Waterconsumption = 0,
                Electricityconsumption = 0

            },
            new SchoolOptions
            {
                Name = "College01",
                UpkeepCost = 50,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                GarbageAccumulation = 0,
                Waterconsumption = 0,
                Electricityconsumption = 0

            },
            new SchoolOptions
            {
                Name = "University01",
                UpkeepCost = 50,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                GarbageAccumulation = 0,
                Waterconsumption = 0,
                Electricityconsumption = 0

            }
        },

        Powerplant_Options = new List<PowerplantOptions>
        {
            new PowerplantOptions
            {
                Name = "GasPowerPlant01",
                UpkeepCost = 50,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                Production = 10000000
            },
            new PowerplantOptions
            {
                Name = "CoalPowerPlant01",
                UpkeepCost = 50,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                Production = 10000000
            },
            new PowerplantOptions
            {
                Name = "NuclearPowerPlant01",
                UpkeepCost = 50,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                Production = 10000000
            },
            new PowerplantOptions
            {
                Name = "SmallCoalPowerPlant01",
                UpkeepCost = 50,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0,
                Production = 10000000
            }
        },

        Waterpump_Options = new List<WaterpumpOptions>
        {
            new WaterpumpOptions
            {
                Name = "WaterPumpingStation01",
                UpkeepCost = 50,
                Capacity = 1000000,
                GarbageAccumulation = 0,
                ElectricityConsumption = 0,
                NoisePollution =0
            },
            new WaterpumpOptions
            {
                Name = "GroundwaterPumpingStation01",
                UpkeepCost = 50,
                Capacity = 1000000,
                GarbageAccumulation = 0,
                ElectricityConsumption = 0,
                NoisePollution =0

            },
            new WaterpumpOptions
            {
                Name = "DesalinationPlant01",
                UpkeepCost = 50,
                Capacity = 1000000,
                GarbageAccumulation = 0,
                ElectricityConsumption = 0,
                NoisePollution = 0

            },
            new WaterpumpOptions
            {
                Name = "WaterTower01",
                UpkeepCost = 50,
                Capacity = 1000000,
                GarbageAccumulation = 0,
                ElectricityConsumption = 0,
                NoisePollution = 0

            }
        },

        Transformerstation_Options = new List<TransformerstationOptions>
        {
            new TransformerstationOptions
            {
                Name = "TransformerStation01",
                UpkeepCost = 50,
                GarbageAccumulation = 0,
                NoisePollution = 0
            }
        },

        Serverfarm_Options = new List<ServerfarmOptions>
        {
            new ServerfarmOptions
            {
                Name = "ServerFarm01",
                UpkeepCost = 50,
                Electricityconsumption = 0,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                Range = 12500,
                Capacity = 200000,
                NoisePollution = 0
            }
        },

        Garbagetruck_Options = new List<GarbagetruckOptions>
        {
            new GarbagetruckOptions
            {
                Name = "GarbageTruck01",
                Capacity = 80000,
                Unloadrate = 10000
            }
        },

        Transportbus_Options = new List<TransportbusOptions>
        {
            new TransportbusOptions
            {
                Name = "Bus01",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "Bus02",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "Bus03",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "TrainPassengerCar01",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "TrainPassengerEngine01",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "SubwayCar01",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "SubwayEngine01",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "TramCar01",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            },
            new TransportbusOptions
            {
                Name = "TramEngine01",
                Passengercapacity = 1000,
                Maintenancerange = 10000
            }
        },

        Parkinghall_Options = new List<ParkinghallOptions>
        {
            new ParkinghallOptions
            {
                Name = "ParkingHall01",
                Upkeep = 50,
                GarageCapacity = 1000,
                Comfortfactor = 1,
                Electricityconsumption = 0,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                Noisepollution = 0
            },
            new ParkinghallOptions
            {
                Name = "ParkingHall02",
                Upkeep = 50,
                GarageCapacity = 1000,
                Comfortfactor = 1,
                Electricityconsumption = 0,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                Noisepollution = 0
            }
        },

        Citypark_Options = new List<CityparkOptions>
        {
            new CityparkOptions
            {
                Name = "CityPark01",
                Upkeep = 50,
                Range = 100000,
                Capacity = 20000,
                Magnitude = 50,
                Attractiveness = 50000,
                Efficiency = 50,
                Electricityconsumption = 0,
                Waterconsumption = 0,
                GarbageAccumulation = 0
                
},
            new CityparkOptions
            {
                Name = "CityPark02",
                Upkeep = 50,
                Range = 100000,
                Capacity = 20000,
                Magnitude = 50,
                Attractiveness = 50000,
                Efficiency = 50,
                Electricityconsumption = 0,
                Waterconsumption = 0,
                GarbageAccumulation = 0
            },
            new CityparkOptions
            {
                Name = "CityPark03",
                Upkeep = 50,
                Range = 100000,
                Capacity = 20000,
                Magnitude = 50,
                Attractiveness = 50000,
                Efficiency = 50,
                Electricityconsumption = 0,
                Waterconsumption = 0,
                GarbageAccumulation = 0

},
            new CityparkOptions
            {
                Name = "CityPark04",
                Upkeep = 50,
                Range = 100000,
                Capacity = 20000,
                Magnitude = 50,
                Attractiveness = 50000,
                Efficiency = 50,
                Electricityconsumption = 0,
                Waterconsumption = 0,
                GarbageAccumulation = 0
            }
        },

        Wastewater_Options = new List<WastewaterOptions>
        {
            new WastewaterOptions
            {
                Name = "WastewaterTreatmentPlant01",
                UpkeepCost = 50,
                Capacity = 10000000,
                Purification = 1,
                GarbageAccumulation = 0,
                GroundPollution = 0,
                AirPollution = 0,
                NoisePollution = 0,
                ElectricityConsumption = 0
            },
            new WastewaterOptions
            {
                Name = "SewageOutlet01",
                UpkeepCost = 50,
                Capacity = 1000000,
                Purification = 1,
                GarbageAccumulation = 0,
                GroundPollution = 0,
                AirPollution = 0,
                NoisePollution = 0,
                ElectricityConsumption = 0
            }
        },

        IncinerationPlant_Options = new List<IncinerationPlantOptions>
        {
            new IncinerationPlantOptions
            {
                Name = "IncinerationPlant01",
                UpkeepCost = 50,
                Waterconsumption = 0,
                GroundPollution = 0,
                AirPollution = 0,
                NoisePollution = 0,
                Garbagecapacity = 3000000,
                Vehiclecapacity = 100
            }
        },

        Healthcare_Options = new List<HealthcareOptions>
        {
            new HealthcareOptions
            {
                Name = "MedicalClinic01",
                UpkeepCost = 50,
                Waterconsumption = 0,
                Electricityconsumption = 0,
                GarbageAccumulation = 0,
                NoisePollution = 0,
                Ambulancecapacity = 50,
                Helicoptercapacity = 25,
                Patientcapacity = 10000,
                Treatmentbonus = 30,
                Capacity = 100000,
                Range = 30000,
                Magnitude = 10
            },
            new HealthcareOptions
            {
                Name = "Hospital01",
                UpkeepCost = 50,
                Waterconsumption = 0,
                Electricityconsumption = 0,
                GarbageAccumulation = 0,
                NoisePollution = 0,
                Ambulancecapacity = 50,
                Helicoptercapacity = 25,
                Patientcapacity = 10000,
                Treatmentbonus = 30,
                Capacity = 100000,
                Range = 30000,
                Magnitude = 10
            }
        },
        
        Postoffice_Options = new List<PostofficeOptions>
        {
            new PostofficeOptions
            {
                Name = "PostOffice01",
                Upkeep = 50,
                Waterconsumption = 0,
                Electricityconsumption = 0,
                GarbageAccumulation = 0,
                Noisepollution = 0,
                Mailboxcapacity = 3000,
                Postvancapacity = 50,
                Mailstoragecapacity = 1000000,
                Capacity = 100000,
                Range = 30000,
                Magnitude = 10
            }
        },

        Cemetery_Options = new List<CemeteryOptions>
        {
            new CemeteryOptions
            {
                Name = "Cemetery01",
                Upkeep = 50,
                Waterconsumption = 0,
                Electricityconsumption = 0,
                GarbageAccumulation = 0,
                Hearsecapacity = 50,
                Storagecapacity = 100000,
                Efficiency = 10
            }
        },

        Crematorium_Options = new List<CrematoriumOptions>
        {
            new CrematoriumOptions
            {
                Name = "Crematorium01",
                Upkeep = 50,
                Waterconsumption = 0,
                Electricityconsumption = 0,
                GarbageAccumulation = 0,
                Hearsecapacity = 50,
                Storagecapacity = 100000,
                Processingrate = 100,
                Airpollution = 0,
                Noisepollution = 0
            }
        },

        Windturbine_Options = new List<WindturbineOptions>
        {
            new WindturbineOptions
            {
                Name = "WindTurbine01",
                Upkeep = 50,
                Production = 100000,
                Maximumwind = 1,
                Noisepollution = 0
            }
        },

        Emergencybattery_Options = new List<EmergencybatteryOptions>
        {
            new EmergencybatteryOptions
            {
                Name = "EmergencyBatteryStation01",
                Upkeep = 50,
                Capacity = 1000000,
                Poweroutput = 400000,
                Noisepollution = 0,
                GarbageAccumulation = 0,
                Waterconsumption = 0
            }
        },

        Geothermalpowerplant_Options = new List<GeothermalpowerplantOptions>
        {
            new GeothermalpowerplantOptions
            {
                Name = "GeothermalPowerPlant01",
                Upkeep = 50,
                Production = 1000000,
                Maximumgroundwater = 400,
                GarbageAccumulation = 0,
                AirPollution = 0,
                GroundPollution = 0,
                NoisePollution = 0
            }
        },

        Solarpowerstation_Options = new List<SolarpowerstationOptions>
        {
            new SolarpowerstationOptions
            {
                Name = "SolarPowerStation01",
                Upkeep = 50,
                Waterconsumption = 0,
                GarbageAccumulation = 0,
                Production = 1000000,
                Poweroutput = 400000,
                Capacity = 1000000,
                NoisePollution = 0
            }
        },

        SignatureResidentialbuilding_Options = new List<SignatureResidentialbuildingOptions>
        {
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialLowSignature01",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialLowSignature02",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialLowSignature03",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialLowSignature01",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialLowSignature02",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialLowSignature03",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialMediumSignature01",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialMediumSignature02",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialMediumSignature03",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialMediumSignature01",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialMediumSignature02",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialMediumSignature03",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialHighSignature01",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialHighSignature02",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "EU_ResidentialHighSignature03",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialHighSignature01",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialHighSignature02",
                Wellbeing = 1000,
                Radius = 5000
            },
            new SignatureResidentialbuildingOptions
            {
                Name = "NA_ResidentialHighSignature03",
                Wellbeing = 1000,
                Radius = 5000
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
            x.Waterconsumption >= 0 &&
            x.GroundPollution >= 0 &&
            x.AirPollution >= 0 &&
            x.NoisePollution >= 0 &&
            x.Garbagecapacity >= 0 &&
            x.Vehiclecapacity >= 0);

        
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
    }
}