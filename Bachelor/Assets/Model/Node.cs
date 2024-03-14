using System.Collections;
using System.Collections.Generic;

namespace DefaultNamespace;
public class Node<Key, Value> where Key : IComparable<Key>
{
    public Key Key { get; set; } // IComparable, this is used in the search to compare
    public Value Value { get; set; } // When inserting numbers, letters etc. both key and value have the same value (the number)

    // Children 
    public Node<Key, Value> Left { get; set; }
    public Node<Key, Value> Right { get; set; }

    // Number of nodes in the subtree
    public int N { get; set; }

    // Color of the link from the parent to this node
    public bool Color { get; set; }

    public Node(Key key, Value val, int n, bool color)
    {
        Key = key;
        Value = val;
        N = n;
        Color = color;
    }
}
