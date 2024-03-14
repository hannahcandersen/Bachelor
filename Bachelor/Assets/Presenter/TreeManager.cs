namespace DefaultNamespace;

public class TreeManager : ITreeManager
{
    public IRedBlackTree RedBlackTree { get; set; }

    public TreeManager(IRedBlackTree redBlackTree)
    {
        RedBlackTree = redBlackTree;
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