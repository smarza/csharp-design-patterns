namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public abstract class WorkflowHandler
{
    protected WorkflowHandler _nextHandlerOnTrue;
    protected WorkflowHandler _nextHandlerOnFalse;

    public WorkflowHandler SetNextOnTrue(WorkflowHandler handler)
    {
        _nextHandlerOnTrue = handler;
        return this; // Permitindo encadeamento
    }

    public WorkflowHandler SetNextOnFalse(WorkflowHandler handler)
    {
        _nextHandlerOnFalse = handler;
        return this; // Permitindo encadeamento
    }

    public abstract void Handle(ConversionTask task);
}
