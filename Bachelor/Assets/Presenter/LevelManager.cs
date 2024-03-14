using System;
using System.Collections.Generic;

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

    public void LoadProgress()
    {
        throw new NotImplementedException();
    }

    public void SaveProgress()
    {
        throw new NotImplementedException();
    }
}
