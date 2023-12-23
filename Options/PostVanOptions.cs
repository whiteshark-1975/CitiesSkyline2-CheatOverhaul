namespace WhitesharkCheatOverhaul;

public class PostVanOptions :
    IBasePrefabOptions,
    IPostVanOptions
{
    public string Name { get; set; } = null!;

    public int MailCapacity { get; set; }


}