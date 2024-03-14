namespace DefaultNamespace;

public class LevelManager : ILevelManager
{
    public List<ILevelData> Levels { get; set; } = new List<ILevelData>();

    public LevelManager()
    {
    }

    public void LoadLevel(int levelIndex)
    {
    }

    public void CompleteLevel(int levelIndex)
    {
    }

    private void LoadProgress()
    {
    }

    private void SaveProgress()
    {
    }
    
}
