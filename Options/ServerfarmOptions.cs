namespace WhitesharkCheatOverhaul;

public class ServerfarmOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    ITelecomFacilityOptions,
    ICityEntertainment,
    ICityTelecomCapacity,
    ICityAttractiveness
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public float TelecomRange { get; set; }
    public float NetworkCapacity { get; set; }
    public float CityEntertainment { get; set; }
    public float CityTelecomCapacity { get; set; }
    public float CityAttractiveness { get; set; }
    
}