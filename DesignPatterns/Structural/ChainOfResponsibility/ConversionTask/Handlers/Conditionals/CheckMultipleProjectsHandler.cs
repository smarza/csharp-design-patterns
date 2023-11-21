namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CheckMultipleProjectsHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        bool condition = true;

        Console.WriteLine($"A Tarefa possui mas de um projeto? [{condition}].");

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
