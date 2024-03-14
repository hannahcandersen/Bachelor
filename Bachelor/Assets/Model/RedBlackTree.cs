using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlackBST<Key extends Comparable<Key>, Value> : IRedBlackBST
  {
     private Node root;
     public void put(Key key, Value val)
     {  // Search for key. Update value if found; grow table if new.
        root = put(root, key, val);
        root.color = BLACK;
}
     private Node put(Node h, Key key, Value val)
     {
        if (h == null)  // Do standard insert, with red link to parent.
           return new Node(key, val, 1, RED);
        int cmp = key.compareTo(h.key);
        if      (cmp < 0) h.left  = put(h.left,  key, val);
        else if (cmp > 0) h.right = put(h.right, key, val);
        else h.val = val;
        
        if (isRed(h.right) && !isRed(h.left))    h = rotateLeft(h);
        if (isRed(h.left) && isRed(h.left.left)) h = rotateRight(h);
        if (isRed(h.left) && isRed(h.right))     flipColors(h);
        
        h.N = size(h.left) + size(h.right) + 1;
        return h; 
     }
  
  private Node rotateLeft(Node h) 
  {
     Node x = h.right;
     h.right = x.left;
     x.left = h;
     x.color = h.color;
     h.color = RED;
     x.N = h.N;
     h.N = 1 + size(h.left) + size(h.right);
     return x;
  }
  
     private boolean isRed(Node x)
     {
        if (x == null) return false;
        return x.color == RED;
     }
  
     private Node rotateRight(Node h) 
     {
        Node x = h.left;
        h.left = x.right;
        x.right = h;
        x.color = h.color;
        h.color = RED;
        x.N = h.N;
        h.N = 1 + size(h.left) + size(h.right);
        return x;
     }
     private void flipColors(Node h)
     {
        h.color = RED;
        h.left.color = BLACK;
        h.right.color = BLACK;
     }

     private int size()
     {
        return size(root);
     }


  }
