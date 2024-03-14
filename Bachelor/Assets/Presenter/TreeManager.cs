using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace;

public class TreeManager : MonoBehaviour, ITreeManager
{
    public IRedBlackTree RedBlackTree { get; set; }

    void Awake()
    {
        // MonoBehaviour classes cannot have constructors, so this is a good place to initialize anything that would normally be done in a constructor.
    }

    public void WaitForRotateRight()
    {
        // Update hint

        // Wait to check which button is pressed
        // Update hint according to the button pressed

        // If correct button is pressed, continue algorithm
    }

    public void WaitForRotateLeft()
    {
        // Update hint

        // Wait to check which button is pressed
        // Update hint according to the button pressed

        // If correct button is pressed, continue algorithm
    }

    public void WaitForFliColour()
    {
        // Update hint

        // Wait to check which button is pressed
        // Update hint according to the button pressed

        // If correct button is pressed, continue algorithm
    }

    public void SetCurrentHint()
    {
    }
}