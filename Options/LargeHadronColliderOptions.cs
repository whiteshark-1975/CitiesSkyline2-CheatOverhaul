namespace WhitesharkCheatOverhaul;

public class LargeHadronColliderOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ICityUniversityInterest,
    ICityOfficeSoftwareDemand,
    ICityIndustrialElectronicDemand,
    ICityOfficeSoftwareEfficiency,
    ICityIndustrialElectronicEfficiency
    
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public float CityUniversityInterest { get; set; }
    public float CityOfficeSoftwareDemand { get; set; }
    public float CityIndustrialElectronicDemand { get; set; }
    public float CityOfficeSoftwareEfficiency { get; set; }
    public float CityIndustrialElectronicEfficiency { get; set; }

}