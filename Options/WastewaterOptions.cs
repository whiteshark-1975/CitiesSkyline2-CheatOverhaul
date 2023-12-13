namespace WhitesharkCheatOverhaul;

public class WastewaterOptions
{
    public string Name { get; set; } = null!;

    public int UpkeepCost { get; set; }
    public int Capacity { get; set; }
    public float Purification { get; set; }
    public int GarbageAccumulation { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int ElectricityConsumption { get; set; }
}
