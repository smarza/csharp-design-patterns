namespace DesignPatterns.Structural.ChainOfResponsibility.PaymentVerification;

public interface IHandler
{
    void SetNext(IHandler handler);
    bool Handle(Request request);
}
