namespace WhitesharkCheatOverhaul;

public class DiseaseControlCenterOptions :
    IBasePrefabOptions,
    IServiceConsumptionOptions,
    IHospitalOptions,
    ICityDiseaseprobability,
    ICityPollutionhealthAffect
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int ElectricityConsumption { get; set; }
    public int WaterConsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int AmbulanceCapacity { get; set; }
    public int HelicopterCapacity { get; set;}
    public int PatientCapacity { get; set; }
    public int TreatmentBonus { get; set; }
    public float CityDiseaseprobability { get; set; }
    public float CityPollutionhealthAffect { get; set; }

}