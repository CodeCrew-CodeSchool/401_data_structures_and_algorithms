namespace CodeChallenges 
{
  public class LinkedList
  {
    public Node Head;

    public void AddNewNode(Node node)
    {
      if (Head != null)
      {
        node.Next = Head;
        Head = node;

      }
      else
      {
        Head = node;
      }
    }

    public bool Includes(int value)
    {
      Node current = Head;
      while (current != null)
      {
        if (current.Value == value)
        {
          return true;
        }

        current = current.Next;
      }

      return false;
    }

    public override string ToString()
    {
      Node current = Head;
      string outputStr = "";
      while (current != null)
      {
        outputStr += $"{current.Value} -> ";
        current = current.Next;
      }

      outputStr += "NULL";
      return outputStr;
    }

  }

  public class Node
  {
    public Node Next;
    public int Value;
    public Node(int value)
    {
      Value = value;
    }
  }
}