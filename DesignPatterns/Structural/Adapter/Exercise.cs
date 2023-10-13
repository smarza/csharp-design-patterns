namespace DesignPatterns.Structural.Adapter;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        IOldPaymentSystem oldPaymentSystem = new OldPaymentSystem();
        oldPaymentSystem.ProcessPayment("1234-5678-9012-3456", 100.0);

        // Utilizando o adapter para usar o novo sistema de pagamento
        IOldPaymentSystem adaptedNewPayment = new PaymentAdapter(new NewPaymentService());
        adaptedNewPayment.ProcessPayment("1234-5678-9012-3456", 150.0);
    }

}
