namespace CodeChallenges
{
  public class InsertableLinkedList : LinkedList
  {
    // Adds a new node with the given value to the end of the list
    public void Append(int value)
    {
      Node newNode = new Node(value);

      if (Head == null)
      {
        Head = newNode;
        Tail = newNode;
      }
      else
      {
        Tail.Next = newNode;
        newNode.Prev = Tail; // Set the previous node reference
        Tail = newNode;
      }
      Length++;
    }

    // Adds a new node with the given new value immediately before the first node that has the value specified
    public void InsertBefore(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert);

      if (Head != null)
      {
        if (Head.Value == value)
        {
          newNode.Next = Head;
          Head.Prev = newNode; // Set the previous node reference
          Head = newNode;
          return;
        }

        Node current = Head;
        while (current.Next != null)
        {
          if (current.Next.Value == value)
          {
            newNode.Next = current.Next;
            newNode.Prev = current; // Set the previous node reference
            current.Next = newNode;
            break;
          }
          current = current.Next;
        }
      }
      Length++;
    }

    // Adds a new node with the given new value immediately after the first node that has the value specified
    public void InsertAfter(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert);

      if (Head != null)
      {
        Node current = Head;
        while (current != null)
        {
          if (current.Value == value)
          {
            newNode.Next = current.Next;
            newNode.Prev = current; 
            current.Next = newNode;
            if (current == Tail)
            {
              Tail = newNode;
            }
            return;
          }

          current = current.Next;
        }
      }
      Length++;
    }
  }
}
