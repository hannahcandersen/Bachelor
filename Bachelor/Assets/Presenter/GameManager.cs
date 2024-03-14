namespace DefaultNamespace;

public class GameManager : IGameManager
{
    public ILevelData LevelData { get; set; } // Info on the current level

    public GameManager(ILevelData levelData)
    {
        LevelData = levelData;
    }

    public GetCurrentIngredient()
    {
    }

    public PlaceIngredient()
    {
    }

    public PlacePlacementCircles()
    {
    }
}
