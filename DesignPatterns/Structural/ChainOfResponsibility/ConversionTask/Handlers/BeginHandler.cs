namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class BeginHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($">> Início\n");
        _nextHandlerOnTrue?.Handle(task);
    }

}
