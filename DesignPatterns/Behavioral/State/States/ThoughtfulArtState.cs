namespace DesignPatterns.Behavioral.State;

public class ThoughtfulArtState : IArtState
{
    public void DisplayArtPiece()
    {
        Console.WriteLine("Showing an thoughtful and deep art piece!");
    }
}
