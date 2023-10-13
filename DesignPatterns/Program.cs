
using DesignPatterns;

Console.Clear();

var exerciseFactory = new ExerciseFactory();

var exercises = new List<string>() {
    "Creational.Singleton.Counter",
    "Creational.Singleton.ThreadSafe",
    "Creational.Factory",
    "Structural.Adapter",
    "Structural.ChainOfResponsibility",
    "Structural.Facade",
    "Behavioral.Mediator",
    "Behavioral.Observer",
    "Behavioral.Proxy.Cache",
    "Behavioral.State",
    "Behavioral.Strategy"
    };

foreach (var exercise in exercises)
{
    exerciseFactory.Execute(exercise);
}

Console.ReadLine();