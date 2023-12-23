namespace WhitesharkCheatOverhaul;

public class GeologicalResearchCenterOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IPollutionOptions,
    ICityOreResourceAmmount,
    ICityOilResourceAmmount
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public float CityOreResourceAmmount { get; set; }
    public float CityOilResourceAmmount { get; set; }
    public float CityCollegegraduation { get; set; }

}