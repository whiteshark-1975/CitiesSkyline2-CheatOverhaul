namespace WhitesharkCheatOverhaul;

public class EarlyDisasterWarningSystemOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float CityDisasterWarningTime { get; set; }
    public float CityDisasterDamageRate { get; set; }


}