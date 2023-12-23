namespace WhitesharkCheatOverhaul;

public class GeothermalpowerplantOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int GarbageAccumulation { get; set; }
    public int Production { get; set; }
    public int Maximumgroundwater { get; set; }
    public int AirPollution { get; set; }
    public int GroundPollution { get; set; }
    public int NoisePollution { get; set; }

}