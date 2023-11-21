namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class UpdateStateToUpdatingHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Muda o estado para 'Atualizando'.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
