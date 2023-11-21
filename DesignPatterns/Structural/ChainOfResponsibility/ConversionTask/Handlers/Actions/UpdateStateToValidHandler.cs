namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class UpdateStateToValidHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Muda o estado para 'Válido'.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
