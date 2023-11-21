namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CheckProjectStateHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        bool condition = task.Jobs.Any(x => x.JobStatus == ConversionJobStatus.Converting);

        Console.WriteLine($"O projeto associado está no estado 'Atualizando'? [{condition}].");

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
