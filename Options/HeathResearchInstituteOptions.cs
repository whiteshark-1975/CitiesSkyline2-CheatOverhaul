namespace WhitesharkCheatOverhaul;

public class HeathResearchInstituteOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public float CityDiseaseprobability { get; set; }
    public float CityParkEntertainment { get; set; }



}