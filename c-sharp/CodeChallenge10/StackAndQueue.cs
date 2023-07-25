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
        Top.Next = newNode;
        Top = newNode;
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

  }
}
