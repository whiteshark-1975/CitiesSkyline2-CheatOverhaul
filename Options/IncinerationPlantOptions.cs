namespace WhitesharkCheatOverhaul;

public class IncinerationPlantOptions
{
    public string Name { get; set; } = null!;

    public int UpkeepCost { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int Garbagecapacity { get; set; }
    public int Vehiclecapacity { get; set; }
    public int Transportcapacity { get; set; }
    public int Processingspeed { get; set; }
    public int Electricityproduction { get; set; }
    public float Productionperunit { get; set; }
    public int ProductionCapacity { get; set; }
    public float CityIndustrialGroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int GroundPollution { get; set; }
    public int NoisePollution { get; set; }
}