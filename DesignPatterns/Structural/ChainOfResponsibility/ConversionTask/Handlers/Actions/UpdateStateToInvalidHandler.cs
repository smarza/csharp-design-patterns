namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class UpdateStateToInvalidHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Muda o estado para 'Inválido'.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
