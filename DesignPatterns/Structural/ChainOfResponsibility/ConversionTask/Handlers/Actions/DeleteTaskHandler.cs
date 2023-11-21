namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class DeleteTaskHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Apaga a tarefa.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
