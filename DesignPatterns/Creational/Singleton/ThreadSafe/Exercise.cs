﻿namespace DesignPatterns.Creational.Singleton.ThreadSafe;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {

        Console.WriteLine(
                    "{0}\n{1}\n\n{2}\n",
                    "If you see the same value, then singleton was reused.",
                    "If you see different values, then 2 singletons were created",
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

    }
    private static void TestSingleton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    }
}
