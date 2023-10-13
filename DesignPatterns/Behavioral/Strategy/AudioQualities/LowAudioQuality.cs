namespace DesignPatterns.Behavioral.Strategy;

public class LowAudioQuality : IAudioQualityStrategy
{
    public void Play()
    {
        Console.WriteLine("Playing music in low quality.");
    }
}
