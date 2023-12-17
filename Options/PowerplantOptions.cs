namespace WhitesharkCheatOverhaul;

public class PowerplantOptions
{
    public string Name { get; set; } = null!;

    public int UpkeepCost { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int AirPollution { get; set; }
    public int GroundPollution { get; set; }
    public int NoisePollution { get; set; }
    public int Production { get; set; }
    public float modifier { get; set; }
}