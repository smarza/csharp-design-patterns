namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CheckConversionJobStateHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        bool condition = task.Projects.Any(x => x.Status == ProjectStatus.Updating);

        Console.WriteLine($"Algum 'Conversion Job' associado está em estado inapropriado? [{condition}].");

        if (condition)
        {
            _nextHandlerOnTrue?.Handle(task);
        }
        else
        {
            _nextHandlerOnFalse?.Handle(task);
        }
    }

}
