namespace WhitesharkCheatOverhaul;

public class PublicTransportDepotsOptions
{
    public string Name { get; set; } = null!;


    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
    public int VehicleCapacity { get; set; }
    public float MaintenanceDuration { get; set; }
    
}