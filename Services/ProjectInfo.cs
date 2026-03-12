public class ProjectInfo
{
    public string Name { get; }
    public string Version { get; }

    public ProjectInfo(IWebHostEnvironment env)
    {
        Name    = env.ApplicationName;
        Version = "1.0.0";
    }
}