namespace DesignPatterns.Structural.Facade;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        var projector = new Projector();
        var light = new Light();
        var amplifier = new Amplifier();

        var homeTheater = new HomeTheaterFacade(projector, light, amplifier);

        homeTheater.PlayMovie("Back to the Future II");
    }

}
