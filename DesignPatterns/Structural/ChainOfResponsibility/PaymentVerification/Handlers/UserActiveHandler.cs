namespace DesignPatterns.Structural.ChainOfResponsibility.PaymentVerification;

public class UserActiveHandler : IHandler
{
    private IHandler? _nextHandler;

    public bool Handle(Request request)
    {
        if (!request.IsUserActive)
        {
            Console.Write("User is not active.");
            return false;
        }

        return _nextHandler?.Handle(request) ?? true;
    }

    public void SetNext(IHandler handler)
    {
        _nextHandler = handler;
    }
}
