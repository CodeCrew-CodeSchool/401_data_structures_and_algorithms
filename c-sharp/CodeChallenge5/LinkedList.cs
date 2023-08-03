namespace CodeChallenges
{
  public class LinkedList
  {
    public Node? Head { get; set; }
    public Node? Tail { get; set; }
    public int Length { get; set; }

    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null)
      {
        node.Next = Head;
        Head.Prev = node; 
        Head = node;
      }
      else
      {
        Head = node;
        Tail = node;
      }
      Length++;
    }

    public bool Includes(int value)
    {
      Node? current = Head;
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
      Node? current = Head;
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
    public Node? Next { get; set; }
    public Node? Prev { get; set; }
    public int Value { get; set; }

    public Node(int value)
    {
      Value = value;
    }
  }

}