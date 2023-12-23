namespace WhitesharkCheatOverhaul;

public class RadioMastOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int Range { get; set; }
    public int NetworkCapacity { get; set; }
    public int NoisePollution { get; set; }


}