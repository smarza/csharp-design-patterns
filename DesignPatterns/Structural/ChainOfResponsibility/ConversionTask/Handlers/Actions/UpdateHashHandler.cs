namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class UpdateHashHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Atualiza o Hash.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
