namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CalculateTaskHashHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Calcula o hash da tarefa.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
