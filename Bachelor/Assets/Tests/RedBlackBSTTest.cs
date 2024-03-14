using NUnit.Framework;

// Unit tests for the RedBlackBST class
public class RedBlackBSTTest
{
    private IRedBlackBST tree;

    [SetUp]
    public void SetUp()
    {
        // Initialize RedBlackBST instance
        tree = new RedBlackBST();

        // Insert nodes into the RedBlackBST
        tree.Put(1, 1);
        tree.Put(2,2);
        tree.Put(3,3);
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
