namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CheckAssociatedFilesHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        bool condition = true;

        Console.WriteLine($"A tarefa tem arquivos associados? [{condition}].");

        if (condition)
        {
            _nextHandlerOnTrue?.Handle(task);
        }
        else
        {
            _nextHandlerOnFalse?.Handle(task);
        }
    }

}
