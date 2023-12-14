namespace WhitesharkCheatOverhaul;

public class FirewatchTowerOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public float ForestFireResponseTime { get; set; }
    public float ForestResponseRadius { get; set; }
    public float ForestFireHazard { get; set; }
    public float ForestFireHazardRadius { get; set; }

}