namespace WhitesharkCheatOverhaul;

public class SolarpowerstationOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    ISolarPoweredOptions,
    IBatteryOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int Production { get; set; }
    public int PowerOutput { get; set; }
    public int BatteryCapacity { get; set; }
    

}