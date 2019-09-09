import java.util.EmptyStackException;

public class LinkedStack<T> implements StackInterface<T>
{
    private Node topNode;
    public LinkedStack()
    {
        topNode = null;
    }


    private class Node
    {
        private T data;
        private Node next;
        private Node(T d, Node n)
        {
            data = d;
            next = n;
        }

        private T getData()
        {
            return data;
        }

        private Node getNextNode()
        {
            return next;
        }
    }

    @Override
    public void push(T newEntry)
    {
        topNode = new Node(newEntry, topNode);
    }

    @Override
    public T pop()
    {
        if(isEmpty())
        {
            throw new EmptyStackException();
        }
        T top = topNode.getData();
        topNode = topNode.getNextNode();
        return top;
    }

    @Override
    public T peek()
    {
        if(isEmpty())
        {
            throw new EmptyStackException();
        }
        return topNode.getData();
    }

    @Override
    public boolean isEmpty()
    {
        return topNode == null;
    }

    @Override
    public void clear()
    {
        topNode = null;
    }
}