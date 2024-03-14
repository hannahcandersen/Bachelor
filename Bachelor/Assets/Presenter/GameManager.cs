using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace;

public class GameManager : MonoBehaviour, IGameManager
{
    public ILevelData LevelData { get; set; } // Info on the current level

    void Awake()
    {
        // MonoBehaviour classes cannot have constructors, so this is a good place to initialize anything that would normally be done in a constructor.
    }

    public Node GetCurrentIngredient()
    {
    }

    public void PlaceIngredient()
    {
    }

    public void PlacePlacementCircles()
    {
    }
}
