﻿namespace WhitesharkCheatOverhaul;

public class ServerfarmOptions
{
    public string Name { get; set; } = null!;

    public int UpkeepCost { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int Range { get; set; }
    public int Capacity { get; set; }
    public int NoisePollution { get; set; }
    public float CityEntertainment { get; set; }
    public float CityTelecomCapacity { get; set; }
    public float CityAttractiveness { get; set; }
    
}