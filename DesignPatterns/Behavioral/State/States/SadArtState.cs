namespace DesignPatterns.Behavioral.State;

public class SadArtState : IArtState
{
    public void DisplayArtPiece()
    {
        Console.WriteLine("Showing an melancholic and black & white art piece!");
    }
}
