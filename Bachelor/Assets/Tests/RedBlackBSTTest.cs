using NUnit.Framework;

// Unit tests for the RedBlackBST class
public class RedBlackBSTTest
{
    private RedBlackBST tree;

    // Example setup from chat
    public void SetUp()
    {
        // Initialize RedBlackBST instance
        tree = new RedBlackBST();

        // Initialize Node instances
        Node firstNode = new Node(1, 1, 1, false);
        Node secondNode = new Node(2, 2, 1, false);
        Node thirdNode = new Node(3, 3, 1, false);

        // Insert nodes into the RedBlackBST
        tree.Put(firstNode.Node_Key, firstNode.Node_Value);
        tree.Put(secondNode.Node_Key, secondNode.Node_Value);
        tree.Put(thirdNode.Node_Key, thirdNode.Node_Value);
    }


    // Example from chat
    [Test]
    public void Insert_IncreasesSize()
    {
        // Arrange
        var initialSize = tree.Size();

        // Act
        tree.Put(4, 4);

        // Assert
        Assert.AreEqual(initialSize + 1, tree.Size());
    }
}
