namespace DesignPatterns.Behavioral.Strategy;

public class MediumAudioQuality : IAudioQualityStrategy
{
    public void Play()
    {
        Console.WriteLine("Playing music in medium quality.");
    }
}
