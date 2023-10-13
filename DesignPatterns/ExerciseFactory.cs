namespace DesignPatterns;

public class ExerciseFactory
{
    private BaseExercise? _exercise;

    public void Execute(string pattern)
    {
        _exercise = (BaseExercise)Activator.CreateInstance(Type.GetType($"DesignPatterns.{pattern}.Exercise"));

        _exercise?.Execute();
    }
}
