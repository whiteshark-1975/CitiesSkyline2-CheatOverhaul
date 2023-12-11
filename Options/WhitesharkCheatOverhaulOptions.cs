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
                Waterconsumption = 1,
                GarbageAccumulation = 1,
                AirPollution = 1,
                GroundPollution = 1,
                NoisePollution = 0,
                Production = 10000000
            },
            new PowerplantOptions
            {
                Name = "CoalPowerPlant01",
                UpkeepCost = 50,
                Waterconsumption = 1,
                GarbageAccumulation = 1,
                AirPollution = 1,
                GroundPollution = 1,
                NoisePollution = 1,
                Production = 10000000
            },
            new PowerplantOptions
            {
                Name = "NuclearPowerPlant01",
                UpkeepCost = 50,
                Waterconsumption = 1,
                GarbageAccumulation = 1,
                AirPollution = 1,
                GroundPollution = 1,
                NoisePollution = 1,
                Production = 10000000
            },
            new PowerplantOptions
            {
                Name = "SmallCoalPowerPlant01",
                UpkeepCost = 50,
                Waterconsumption = 1,
                GarbageAccumulation = 1,
                AirPollution = 1,
                GroundPollution = 1,
                NoisePollution = 1,
                Production = 10000000
            }
        },

        Waterpump_Options = new List<WaterpumpOptions>
        {
            new WaterpumpOptions
            {
                Name = "WaterPumpingStation01",
                UpkeepCost = 12,
            },
            new WaterpumpOptions
            {
                Name = "GroundwaterPumpingStation01",
                UpkeepCost = 12,
               
            },
            new WaterpumpOptions
            {
                Name = "DesalinationPlant01",
                UpkeepCost = 12,
           
            },
            new WaterpumpOptions
            {
                Name = "WaterTower01",
                UpkeepCost = 12,
             
            }
        }
    };

    public IEnumerable<SchoolOptions> School_Options { get; set; }
    public IEnumerable<PowerplantOptions> Powerplant_Options { get; set; }
    public IEnumerable<WaterpumpOptions> Waterpump_Options { get; set; }


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
    public void RemoveBadEntires()
    {
        var School_length = School_Options.Count();
        School_Options = School_Options.Where(x => !string.IsNullOrEmpty(x.Name) && x.UpkeepCost >= 0);
    
        var Waterpump_length = Waterpump_Options.Count();
        Waterpump_Options = Waterpump_Options.Where(x => !string.IsNullOrEmpty(x.Name) && x.UpkeepCost >= 0);
      
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
  
    }
}