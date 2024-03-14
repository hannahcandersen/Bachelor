public interface ILevelManager
{
    public void LoadLevel(int levelIndex);
    public void CompleteLevel(int levelIndex);
    public void LoadProgress();
    public void SaveProgress();
}