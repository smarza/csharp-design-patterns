namespace DesignPatterns.Behavioral.State;

public class ArtDisplay
{
    private IArtState _state;

    public ArtDisplay(IArtState initialState)
    {
        _state = initialState;
    }

    public void SetState(IArtState state)
    {
        _state = state;
    }

    public void ShowArt()
    {
        Console.WriteLine($"Current state: {_state.GetType().Name.Replace("ArtState", "")}");

        _state.DisplayArtPiece();

        Console.WriteLine("");
    }
}
