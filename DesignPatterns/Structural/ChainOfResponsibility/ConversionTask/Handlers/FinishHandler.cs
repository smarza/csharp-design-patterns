namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class FinishHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"\n>> Fim\n");
        _nextHandlerOnTrue?.Handle(task);
    }

}
