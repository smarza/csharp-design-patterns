namespace DesignPatterns.Structural.Adapter;

public class PaymentAdapter : IOldPaymentSystem
{
    private readonly INewPaymentService _newPaymentService;

    public PaymentAdapter(INewPaymentService newPaymentService)
    {
        _newPaymentService = newPaymentService;
    }

    public void ProcessPayment(string cardNumber, double amount)
    {
        _newPaymentService.ExecuteTransaction(cardNumber, amount);
    }
}
