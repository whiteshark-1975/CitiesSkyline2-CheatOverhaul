﻿namespace WhitesharkCheatOverhaul;

public class PoliceCarOptions :
    IBasePrefabOptions,
    IPoliceCarOptions
{
    public string Name { get; set; } = null!;

    public int CriminalCapacity { get; set; }
    public float CrimeReductionRate { get; set; }


}