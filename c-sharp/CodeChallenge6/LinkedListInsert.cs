namespace CodeChallenges 
{
  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }
  }
  public class LinkedList
  {
    public Node Head { get; set; }
  }
  public class InsertableLinkedList : LinkedList
  {
    public void Append(int value)
    {
      Node newNode = new Node { Value = value };
      if (Head == null)
      {
        Head = newNode;
      }
      else
      {
        Node current = Head;
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = newNode;
      }
    }
    public void Insert(int value)
    {
      Node newNode = new Node { Value = value };
      if (Head == null)
      {
        Head = newNode;
      }
      else
      {
        newNode.Next = Head;
        Head = newNode;
      }
    }
    public void InsertBefore(int value, int valueToInsert)
    {
      if (Head == null)
      {
        return;
      }
      Node newNode = new Node { Value = valueToInsert };
      if (Head.Value == value)
      {
        newNode.Next = Head;
        Head = newNode;
        return;
      }
      Node current = Head;
      while (current.Next != null)
      {
        if (current.Next.Value == value)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
          return;
        }
        current = current.Next;
      }
    }
    public void InsertAfter(int value, int valueToInsert)
    {
      Node newNode = new Node { Value = valueToInsert };
      if (Head == null)
      {
        Head = newNode;
        return;
      }
      Node current = Head;
      while (current != null)
      {
        if (current.Value == value)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
          return;
        }
        current = current.Next;
      }
    }
  }

  /*public class InsertableLinkedList: LinkedList
  {

      //adds a new node with the given value to the end of the list
      public void Append(int value)
      {

      }
      //adds a new node with the given new value immediately before the first node that has the value specified
      public void InsertBefore(int value, int valueToInsert)
      {

      }
      //adds a new node with the given new value immediately after the first node that has the value specified
      public void InsertAfter(int value, int valueToInsert)
      {

      }
  }*/
}
