namespace DesignPatterns.Structural.ChainOfResponsibility;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        var userActiveHandler = new UserActiveHandler();
        var balanceHandler = new BalanceHandler();
        var stockHandler = new StockHandler();

        userActiveHandler.SetNext(balanceHandler);
        balanceHandler.SetNext(stockHandler);

        var requests = new Dictionary<string, Request>();

        requests.Add("A1", new Request { IsUserActive = true, UserBalance = 40, ProductPrice = 50.0, ProductStock = 5 });
        requests.Add("A2", new Request { IsUserActive = false, UserBalance = 100.0, ProductPrice = 50.0, ProductStock = 5 });
        requests.Add("A3", new Request { IsUserActive = true, UserBalance = 100.0, ProductPrice = 50.0, ProductStock = 0 });
        requests.Add("A4", new Request { IsUserActive = true, UserBalance = 100.0, ProductPrice = 50.0, ProductStock = 5 });

        foreach (var request in requests)
        {
            var approved = false;

            Console.Write($"Verifing Purchase {request.Key}: ");

            if (userActiveHandler.Handle(request.Value))
            {
                approved = true;
            }

            var message = approved ? "(approved)" : " (rejected)";

            Console.Write($"{message}\n");
        }

    }

}
