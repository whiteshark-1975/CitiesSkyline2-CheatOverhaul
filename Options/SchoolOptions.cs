namespace WhitesharkCheatOverhaul;

public class SchoolOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions
{
    public string Name { get; set; } = null!;

    public int AirPollution { get; set; }
    public int Upkeep { get; set; }
    public int GroundPollution { get; set; }
    public int NoisePollution { get; set; }
    public int GarbageAccumulation { get; set; }
    public int TelecomNeed { get; set; }
    public int WaterConsumption { get; set; }
    public int ElectricityConsumption { get; set; }

}