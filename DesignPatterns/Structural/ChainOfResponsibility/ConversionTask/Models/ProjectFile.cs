namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class ProjectFile
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Hash { get; set; }

    public ProjectFile(string name)
    {
        Name = name;

        Id = new Guid();
        Hash = new Guid().ToString();
    }

}
