namespace DesignPatterns.Behavioral.State;

public class HappyArtState : IArtState
{
    public void DisplayArtPiece()
    {
        Console.WriteLine("Showing an vibrant and colorful art piece!");
    }
}
