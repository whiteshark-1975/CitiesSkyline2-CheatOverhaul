﻿namespace WhitesharkCheatOverhaul;

public class MaintenanceDepotOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IMaintenanceDepotOptions,
    IPollutionOptions

    

{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float TelecomNeed { get; set; }
    public int VehicleCapacity { get; set; }
    public float VehicleEfficiency { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set; }
}