namespace DesignPatterns.Creational.Singleton;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {

        Console.WriteLine(
                    "{0}\n{1}\n\n{2}\n",
                    "If you see the same value, then singleton was reused (yay!)",
                    "If you see different values, then 2 singletons were created (booo!!)",
                    "RESULT:"
                );

        Thread process1 = new Thread(() =>
        {
            TestSingleton("FOO");
        });

        Thread process2 = new Thread(() =>
        {
            TestSingleton("BAR");
        });

        process1.Start();
        process2.Start();

        process1.Join();
        process2.Join();

        var counter = Counter.Instance;

        counter.Add();
        counter.Add();
        counter.Add();

        Console.WriteLine($"Counter = {counter.Reveal()}");

    }
    private static void TestSingleton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    }
}
