namespace DesignPatterns.Structural.ChainOfResponsibility.PaymentVerification;

public class StockHandler : IHandler
{
    private IHandler? _nextHandler;

    public bool Handle(Request request)
    {
        if (request.ProductStock <= 0)
        {
            Console.Write("Product out of stock.");
            return false;
        }

        return _nextHandler?.Handle(request) ?? true;
    }

    public void SetNext(IHandler handler)
    {
        _nextHandler = handler;
    }
}
