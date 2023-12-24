﻿namespace WhitesharkCheatOverhaul;

public class MedicalUniversityOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    ISchoolOptions,
    IPollutionOptions,
    ICityRecoverFailChange,
    ICityHospitalEfficiency
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int TelecomNeed { get; set; }
    public int StudentCapacity { get; set; }
    public int GroundPollution { get; set; }
    public int AirPollution { get; set; }
    public int NoisePollution { get; set;}
    public float CityRecoverFailChange { get; set; }
    public float CityHospitalEfficiency { get; set; }

}