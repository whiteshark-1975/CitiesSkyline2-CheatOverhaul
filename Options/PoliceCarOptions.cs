namespace WhitesharkCheatOverhaul;

public class PoliceCarOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int CriminalCapacity { get; set; }
    public int CrimeReductionRate { get; set; }


}