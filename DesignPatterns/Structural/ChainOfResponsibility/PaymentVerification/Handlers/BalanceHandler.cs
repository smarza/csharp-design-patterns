namespace DesignPatterns.Structural.ChainOfResponsibility.PaymentVerification;

public class BalanceHandler : IHandler
{
    private IHandler? _nextHandler;

    public bool Handle(Request request)
    {
        if (request.UserBalance < request.ProductPrice)
        {
            Console.Write("Insufficient balance.");
            return false;
        }

        return _nextHandler?.Handle(request) ?? true;
    }

    public void SetNext(IHandler handler)
    {
        _nextHandler = handler;
    }
}
