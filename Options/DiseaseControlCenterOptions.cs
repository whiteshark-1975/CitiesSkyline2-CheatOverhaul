﻿namespace WhitesharkCheatOverhaul;

public class DiseaseControlCenterOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int AmbulanceCapacity { get; set; }
    public int MedicalHelicopterCapacity { get; set;}
    public int PatientCapacity { get; set; }
    public int TreatmentBonus { get; set; }
    public float CityDiseaseprobability { get; set; }
    public float CityPollutionhealthAffect { get; set; }

}