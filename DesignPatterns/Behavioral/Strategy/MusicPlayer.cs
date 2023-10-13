namespace DesignPatterns.Behavioral.Strategy;

public class MusicPlayer
{
    private IAudioQualityStrategy _qualityStrategy;

    public MusicPlayer(IAudioQualityStrategy audioQualityStrategy)
    {
        _qualityStrategy = audioQualityStrategy;
    }

    public void SetQuality(IAudioQualityStrategy qualityStrategy)
    {
        _qualityStrategy = qualityStrategy;
    }

    public void PlayMusic()
    {
        _qualityStrategy.Play();
    }

}
