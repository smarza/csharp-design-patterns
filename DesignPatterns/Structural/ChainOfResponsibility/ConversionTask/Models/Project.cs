namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ProjectStatus Status { get; set; }

    public Project(string name)
    {
        Name = name;

        Id = new Guid();
        Status = ProjectStatus.Idle;
    }

}
