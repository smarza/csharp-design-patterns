using System.Xml;

namespace DesignPatterns.Behavioral.State;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        var display = new ArtDisplay(new HappyArtState());

        display.ShowArt();

        display.SetState(new SadArtState());
        display.ShowArt();

        display.SetState(new ThoughtfulArtState());
        display.ShowArt();
    }

}
