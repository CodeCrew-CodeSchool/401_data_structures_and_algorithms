namespace CodeChallenges
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void Insert(int value)
    {
      Node newNode = new Node (value);

      if (Head == null)
      {
        Head = newNode;
      }else
      {
        newNode.Next = Head;
        Head = newNode;
      }
    }
  }

  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
    }
  }
}
