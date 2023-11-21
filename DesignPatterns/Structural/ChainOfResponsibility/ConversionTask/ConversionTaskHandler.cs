namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public abstract class ConversionTaskHandler
{
    protected ConversionTaskHandler _nextHandlerOnTrue;
    protected ConversionTaskHandler _nextHandlerOnFalse;

    public ConversionTaskHandler SetNextOnTrue(ConversionTaskHandler handler)
    {
        _nextHandlerOnTrue = handler;
        return this; // Permitindo encadeamento
    }

    public ConversionTaskHandler SetNextOnFalse(ConversionTaskHandler handler)
    {
        _nextHandlerOnFalse = handler;
        return this; // Permitindo encadeamento
    }

    public abstract void Handle(ConversionTask task);
}
