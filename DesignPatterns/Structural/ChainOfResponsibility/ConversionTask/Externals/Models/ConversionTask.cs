namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class ConversionTask
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Hash { get; set; }
    public ConversionTaskStatus Status { get; set; }
    public List<ConversionJob> Jobs { get; set; }
    public List<Project> Projects { get; set; }
    public List<ProjectFile> Files { get; set; }

    public ConversionTask(string name)
    {
        Name = name;

        Id = new Guid();
        Status = ConversionTaskStatus.Valid;
        Hash = new Guid().ToString();
        Jobs = new List<ConversionJob>();
        Projects = new List<Project>();
        Files = new List<ProjectFile>();
    }

}
