namespace WhitesharkCheatOverhaul;

public class IncinerationPlantOptions
{
    public string Name { get; set; } = null!;

    public int UpkeepCost { get; set; }
    public int Waterconsumption { get; set; }
     public int AirPollution { get; set; }
    public int GroundPollution { get; set; }
    public int NoisePollution { get; set; }
    public int Garbagecapacity { get; set; }
    public int Vehiclecapacity { get; set; }
}