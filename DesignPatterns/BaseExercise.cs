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
            string exerciseName = parts.Length > 3 ? parts[3] : string.Empty;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n------------------------------------------------------------------");
            Console.WriteLine($"{patternType.ToUpper()}: {patternName} {exerciseName}\n");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Namespace format is not as expected.");
        }

    }

    public abstract void Execute();
}
