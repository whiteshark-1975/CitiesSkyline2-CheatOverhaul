namespace WhitesharkCheatOverhaul;

public class RadioTelescopeOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float CityUniversityGraduation { get; set; }

}