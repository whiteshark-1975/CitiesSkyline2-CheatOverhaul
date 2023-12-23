namespace WhitesharkCheatOverhaul;

public class PostMailboxOptions :
    IBasePrefabOptions
{
    public string Name { get; set; } = null!;
  
    public int Mailcapacity { get; set; }
    public float Range { get; set; }
    public float Capacity { get; set; }
    public float Magnitude { get; set; }
    public float ComfortFactor { get; set; }

}