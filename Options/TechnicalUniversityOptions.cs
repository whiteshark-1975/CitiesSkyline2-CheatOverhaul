    namespace WhitesharkCheatOverhaul;

    public class TechnicalUniversityOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    ISchoolOptions,
    ICityIndustrialEfficiency,
    ICityOfficeEfficiency
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int TelecomNeed { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int StudentCapacity { get; set; }
    
    public float CityIndustrialEfficiency { get; set; }
    public float CityOfficeEfficiency { get; set; }
    
    }