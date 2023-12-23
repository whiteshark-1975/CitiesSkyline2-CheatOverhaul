namespace WhitesharkCheatOverhaul;

public class SignatureOfficebuildingOptions :
    IBasePrefabOptions,
    IAttractionOptions,
    IPollutionOptions,
    ILocalWellbeing,
    ILocalCrimeAccumulation,
    ICityOfficeEfficiency,
    ICityUniversityInterest,
    ICityUniversityGraduation
    
{
    public string Name { get; set; } = null!;

    public int Attractiveness { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public float LocalWellbeing { get; set; }
    public float LocalWellbeingRadius { get; set; }
    public float LocalCrimeAccumulation { get; set; }
    public float LocalCrimeAccumulationRadius { get; set; }
    public float CityOfficeEfficiency { get; set; }
    public float CityUniversityInterest { get; set; }
    public float CityUniversityGraduation { get; set; }
    
}