namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class CheckFilesInInputFolderHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        bool condition = true;

        Console.WriteLine($"Os arquivos da tarefa estão presentes na pasta de entrada? [{condition}].");

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
