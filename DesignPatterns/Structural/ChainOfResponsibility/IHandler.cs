namespace DesignPatterns.Structural.ChainOfResponsibility;

public interface IHandler
{
    void SetNext(IHandler handler);
    bool Handle(Request request);
}
