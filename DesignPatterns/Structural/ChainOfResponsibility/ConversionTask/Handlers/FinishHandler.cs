namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class FinishHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"\n>> Fim\n");
        _nextHandlerOnTrue?.Handle(task);
    }

}
