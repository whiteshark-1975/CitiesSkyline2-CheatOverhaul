namespace WhitesharkCheatOverhaul;

public class PostMailboxOptions :
    IBasePrefabOptions,
    IMailboxOptions,
    IServiceCoverageOptions
{
    public string Name { get; set; } = null!;
  
    public int Mailcapacity { get; set; }
    public float ServiceCoverageRange { get; set; }
    public float ServiceCoverageCapacity { get; set; }
    public float ServiceCoverageMagnitude { get; set; }
    public float ComfortFactor { get; set; }

}