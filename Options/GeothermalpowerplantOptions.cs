namespace WhitesharkCheatOverhaul;

public class GeothermalpowerplantOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    IGroundWaterPoweredOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public int AirPollution { get; set; }
    public int GroundPollution { get; set; }
    public int NoisePollution { get; set; }
    public int Production { get; set; }
    public int MaximumGroundwater { get; set; }
    
}