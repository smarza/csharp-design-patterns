namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class RemoveProjectAssociationHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Remove a associação do projeto.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
