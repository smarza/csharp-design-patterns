namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CheckRemoveEmptyTaskFlagHandler : ConversionTaskHandler
{

    public override void Handle(ConversionTask task)
    {
        bool condition = true;

        Console.WriteLine($"A flag 'RemoveEmptyTask' do projeto está verdadeira? [{condition}].");

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
