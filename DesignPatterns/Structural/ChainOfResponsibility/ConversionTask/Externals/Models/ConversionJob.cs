namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class ConversionJob
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ConversionJobStatus JobStatus { get; set; }
    public ConversionJob(string name)
    {
        Name = name;

        Id = new Guid();
        JobStatus = ConversionJobStatus.Idle;
    }

}
