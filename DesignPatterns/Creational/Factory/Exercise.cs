namespace DesignPatterns.Creational.Factory;

public class Exercise : BaseExercise
{

    public Exercise() : base()
    {
    }

    public override void Execute()
    {

        Logistics logistics;

        logistics = new RoadLogistics();
        Console.WriteLine(logistics.PlanDelivery());

        logistics = new SeaLogistics();
        Console.WriteLine(logistics.PlanDelivery());
    }

}
