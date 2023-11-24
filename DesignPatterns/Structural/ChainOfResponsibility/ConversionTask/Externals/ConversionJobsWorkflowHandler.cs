namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class ConversionJobsWorkflowHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Fluxo de Conversion Jobs.");
        _nextHandlerOnTrue?.Handle(task);
    }

}
