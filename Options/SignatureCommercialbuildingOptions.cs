namespace WhitesharkCheatOverhaul;

public class SignatureCommercialbuildingOptions :
    IBasePrefabOptions,
    IAttractionOptions,
    ILocalWellbeing,
    IPollutionOptions,
    ICityAttractiveness,
    ICityImportcost
{
    public string Name { get; set; } = null!;

    public int Attractiveness { get; set; }
    public float LocalWellbeing { get; set; }
    public float LocalWellbeingRadius { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }

    public float CityImportcost { get; set; }
    public float CityAttractiveness { get; set; }
    
    
}