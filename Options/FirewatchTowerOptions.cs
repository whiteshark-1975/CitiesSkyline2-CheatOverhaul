namespace WhitesharkCheatOverhaul;

public class FirewatchTowerOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ILocalForestFireHazard,
    ILocalForestFireResponseTime
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int TelecomNeed { get; set; }
    public float LocalForestFireResponseTime { get; set; }
    public float LocalForestFireResponseTimeRadius { get; set; }
    public float LocalForestFireHazard { get; set; }
    public float LocalForestFireHazardRadius { get; set; }

}