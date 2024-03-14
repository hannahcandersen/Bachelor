using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    Key key;
    Value val;
    Node left, right;
    int N;
    bool color;

    Node(Key key, Value val, int N, boolean color)
    {
        this.key = key;
        this.val = val;
        this.N = N;
        this.color = color;
    }
}
