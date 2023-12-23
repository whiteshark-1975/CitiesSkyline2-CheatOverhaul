namespace WhitesharkCheatOverhaul;

public class PrisonOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int UpkeepCost { get; set; }
    public int Electricityconsumption { get; set; }
    public int Waterconsumption { get; set; }
    public int GarbageAccumulation { get; set; }
    public int NoisePollution { get; set; }
    public int PrisonVanCapacity { get; set; }
    public int PrisonerCapacity { get; set; }
    public float CrimeAccumulation { get; set; }
    public float CrimeAccumlationRadius { get; set; }
}