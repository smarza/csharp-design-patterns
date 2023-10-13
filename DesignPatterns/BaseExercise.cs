namespace DesignPatterns;

public abstract class BaseExercise
{
    public BaseExercise()
    {
        var project = GetType().Namespace ?? "";

        string[] parts = project.Split('.');

        if (parts.Length >= 3)
        {
            string patternType = parts[1];
            string patternName = parts[2];

            Console.WriteLine($"\n\n------------------------------------------------------------------");
            Console.WriteLine($"{patternType.ToUpper()}: {patternName}\n");
        }
        else
        {
            Console.WriteLine("Namespace format is not as expected.");
        }

    }

    public abstract void Execute();
}
