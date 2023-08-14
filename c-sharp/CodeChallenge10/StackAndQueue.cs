namespace CodeChallenges
{
  public class Node
  {
    public Node Next { get; set; }
    public int Value { get; set; }

    public Node(int val)
    {
      Value = val;
    }
  }

  public class Stack
  {
    public Node? Top { get; set; } = null;

    public void Push(int val)
    {
      Node newNode = new Node(val);
      
      if(Top != null)
      {
        newNode.Next = Top;
      }
      Top = newNode;
    }

    public int Pop()
    {
      if (Top == null)
      {
        throw new Exception("Stack is empty");
      }

      int result = Top.Value;
      Top = Top.Next;
      return result;
    }

    public int Peek()
    {
      if(Top == null)
      {
        throw new Exception("Stack is empty");
      }
      return Top.Value;
    }

    public bool IsEmpty()
    {
      if (Top == null)
      {
        return true;
      }
      return false;
    }
  }


  public class Queue
  {
    Node Front { get; set; } = null;

    public void Enqueue(int val)
    {
      Node newNode = new Node(val);

      if(Front == null)
      {
        Front = newNode;
        return;
      }

      Node current = Front;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = newNode;
      
    }

    public int Dequeue()
    {
      if (Front == null)
      {
        throw new Exception("Stack is empty");
      }

      int result = Front.Value;
      Front = Front.Next;
      return result;
    }

    public int Peek()
    {
      if (Front == null)
      {
        throw new Exception("Stack is empty");
      }
      return Front.Value;
    }

    public bool IsEmpty()
    {

      if (Front == null)
      {
        return true;
      }
      return false;
    }
  }
}
