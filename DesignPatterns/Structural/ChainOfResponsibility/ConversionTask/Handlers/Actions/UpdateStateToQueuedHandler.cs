namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class UpdateStateToQueuedHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Muda o estado de todas as 'Conversion Jobs' associadas para 'Na Fila de Conversão'.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
