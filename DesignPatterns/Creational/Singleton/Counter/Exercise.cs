namespace DesignPatterns.Creational.Singleton.Counter;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {

        Console.WriteLine("Counter A is requiring Counter Instance");
        var counterA = Counter.Instance;
        
        counterA.Add();
        counterA.Add();

        Console.WriteLine("\nCounter B is requiring Counter Instance");
        var counterB = Counter.Instance;

        counterB.Add();

        Console.WriteLine($"\nCounter A is {counterA.Reveal()}");
        Console.WriteLine($"Counter B is {counterB.Reveal()}");

    }

}
