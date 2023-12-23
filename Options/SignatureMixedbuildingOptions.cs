namespace WhitesharkCheatOverhaul;

public class SignatureMixedbuildingOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;

    public int Attractiveness { get; set; }
    public float Wellbeing { get; set; }
    public float Radius { get; set; }
    public float CityAttractiveness { get; set; }
    public int Noisepollution { get; set; }

}