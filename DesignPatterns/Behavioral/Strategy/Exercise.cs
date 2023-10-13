namespace DesignPatterns.Behavioral.Strategy;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        var player = new MusicPlayer(new MediumAudioQuality());
        player.PlayMusic();

        player.SetQuality(new HighAudioQuality());
        player.PlayMusic();

        player.SetQuality(new LowAudioQuality());
        player.PlayMusic();
    }

}
