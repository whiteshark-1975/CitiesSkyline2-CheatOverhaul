namespace WhitesharkCheatOverhaul;

public class EarlyDisasterWarningSystemOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ICityDisasterWarningTime,
    ICityDisasterDamageRate
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float CityDisasterWarningTime { get; set; }
    public float CityDisasterDamageRate { get; set; }


}