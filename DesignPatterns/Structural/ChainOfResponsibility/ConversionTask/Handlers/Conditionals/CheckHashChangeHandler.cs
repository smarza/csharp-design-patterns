namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CheckHashChangeHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        bool condition = true;

        Console.WriteLine($"O hash da Tarefa mudou? [{condition}].");

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
