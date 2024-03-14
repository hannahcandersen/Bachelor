using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace;

public class LevelManager : MonoBehaviour, ILevelManager
{
    public List<ILevelData> Levels { get; set; } = new List<ILevelData>();

    void Awake()
    {
        // MonoBehaviour classes cannot have constructors, so this is a good place to initialize anything that would normally be done in a constructor.
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
