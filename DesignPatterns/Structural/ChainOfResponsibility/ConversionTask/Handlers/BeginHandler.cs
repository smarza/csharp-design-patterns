namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class BeginHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($">> Início\n");
        _nextHandlerOnTrue?.Handle(task);
    }

}
