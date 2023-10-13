namespace DesignPatterns.Behavioral.Strategy;

public class HighAudioQuality : IAudioQualityStrategy
{
    public void Play()
    {
        Console.WriteLine("Playing music in high quality.");
    }
}
