namespace WhitesharkCheatOverhaul;

public class WindturbineOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Upkeep { get; set; }
    public float Maximumwind { get; set; }
    public int Production { get; set; }
    public int Noisepollution { get; set; }

}