namespace DesignPatterns.Behavioral.Proxy.Cache;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {
        ICat tiquinho = new CatProxy("Tiquinho");

        tiquinho.ShowData();
        tiquinho.ShowData();

        ICat tuka = new CatProxy("Tuka");

        tuka.ShowData();
        tuka.ShowData();
    }

}
