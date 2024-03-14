using System;

public class Node
{
    public int Node_Key { get; set; }

    public int Node_Value { get; set; } // When inserting numbers, letters etc. both key and value have the same value (the number)

    // Children 
    public Node Left { get; set; }
    public Node Right { get; set; }

    // Number of nodes in the subtree
    public int N { get; set; }

    // Color of the link from the parent to this node
    public bool Color { get; set; }

    public Node(int key, int val, int n, bool color)
    {
        Node_Key = key;
        Node_Value = val;
        N = n;
        Color = color;
    }
}
