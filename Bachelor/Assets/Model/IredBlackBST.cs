namespace DefaultNamespace;

public interface IRedBlackBST<Key, Value>
{
    public void Put(Key key, Value val);

    public int Size();
}