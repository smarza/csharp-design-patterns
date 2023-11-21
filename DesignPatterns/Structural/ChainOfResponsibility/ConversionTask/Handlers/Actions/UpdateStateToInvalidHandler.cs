namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class UpdateStateToInvalidHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Muda o estado para 'Inválido'.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
