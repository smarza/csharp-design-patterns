namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class UpdateStateToValidHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Muda o estado para 'Válido'.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
