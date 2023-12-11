using System.Collections.Generic;
using System.Linq;

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
                UpkeepCost = 10,
                
            },
            new SchoolOptions
            {
                Name = "ElementarySchool01 Extension Wing",
                UpkeepCost = 10,
                
            },
            new SchoolOptions
            {
                Name = "College01 Extension Wing",
                UpkeepCost = 10,
                
            },
            new SchoolOptions
            {
                Name = "University01",
                UpkeepCost = 10,
                
            },
            new SchoolOptions
            {
                Name = "University01 Extension Wing",
                UpkeepCost = 10,
                
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




    public void RemoveBadEntires()
    {
        var School_length = School_Options.Count();
        School_Options = School_Options.Where(x => !string.IsNullOrEmpty(x.Name) && x.UpkeepCost >= 0);
   
        var Powerplant_length = Powerplant_Options.Count();
        Powerplant_Options = Powerplant_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.AirPollution >= 0 &&
            x.GroundPollution >= 0 &&
            x.NoisePollution >= 0 &&
            x.Production >= 0);

        var Waterpump_length = Waterpump_Options.Count();
        Waterpump_Options = Waterpump_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Capacity >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.ElectricityConsumption >= 0 &&
            x.NoisePollution >= 0);

        var Transformerstation_length = Transformerstation_Options.Count();
        Transformerstation_Options = Transformerstation_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.NoisePollution >= 0);

        var Serverfarm_length = Serverfarm_Options.Count();
        Serverfarm_Options = Serverfarm_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.UpkeepCost >= 0 &&
            x.Electricityconsumption >= 0 &&
            x.Waterconsumption >= 0 &&
            x.GarbageAccumulation >= 0 &&
            x.Range >= 0 &&
            x.Capacity >= 0 &&
            x.NoisePollution >= 0);

        var Garbagetruck_length = Garbagetruck_Options.Count();
        Garbagetruck_Options = Garbagetruck_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Capacity >= 0 &&
            x.Unloadrate >= 0);

        var Transportbus_length = Transportbus_Options.Count();
        Transportbus_Options = Transportbus_Options.Where(
            x => !string.IsNullOrEmpty(x.Name) &&
            x.Passengercapacity >= 0 &&
            x.Maintenancerange >= 0);
    }
}