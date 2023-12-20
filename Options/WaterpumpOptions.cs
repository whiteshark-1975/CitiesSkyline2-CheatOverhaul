namespace WhitesharkCheatOverhaul;

public class WaterpumpOptions
{
    public string Name { get; set; } = null!;

    public int UpkeepCost { get; set; }
    public int Capacity { get; set; }
    public int GarbageAccumulation { get; set; }
    public int ElectricityConsumption { get; set; }
    public int NoisePollution { get; set; }
    public float Purification  { get; set; }

}
