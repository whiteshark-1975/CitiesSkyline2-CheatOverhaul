    namespace WhitesharkCheatOverhaul;

    public class TechnicalUniversityOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int StudentCapacity { get; set; }
    public int NoisePollution { get; set;}
    public float CityIndustrialEfficiency { get; set; }
    public float CityOfficeEfficiency { get; set; }
    
    }