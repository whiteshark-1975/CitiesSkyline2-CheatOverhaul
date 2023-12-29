namespace WhitesharkCheatOverhaul;

public class RadioMastOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ITelecomFacilityOptions,
    IPollutionOptions
    
    
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public float TelecomRange { get; set; }
    public float NetworkCapacity { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }


}