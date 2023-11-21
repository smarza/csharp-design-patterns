namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class ConversionJobsWorkflowHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Fluxo de Conversion Jobs.");
        _nextHandlerOnTrue?.Handle(task);
    }

}
