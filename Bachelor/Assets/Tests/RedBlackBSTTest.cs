using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DefaultNamespace;

// Unit tests for the RedBlackBST class
public class RedBlackBSTTest
{
    private IRedBlackBST<int, string> tree;

    // Example setup from chat
    [SetUp]
    public void SetUp()
    {
        tree = new RedBlackBST<int, string>();
        firstNode = new Node(1, 1, 1, false);
        secondNode = new Node(2, 2, 1, false);
        thirdNode = new Node(3, 3, 1, false);
        tree.Put(1, "One");
        tree.Put(2, "Two");
        tree.Put(3, "Three");
    }

    // Example from chat
    [Test]
    public void Insert_IncreasesSize()
    {
        // Arrange
        var initialSize = tree.Size();

        // Act
        tree.Insert(4, 4);

        // Assert
        Assert.AreEqual(initialSize + 1, tree.Size());
    }
}
