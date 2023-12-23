namespace WhitesharkCheatOverhaul;

public class PublicTransportStationsOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;


    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int NoisePollution { get; set; }
    public int StorageLimit { get; set; }
    public int Transports { get; set; }
    public float ComfortFactor { get; set; }

}