namespace CodeChallenges
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void insert(int data)
    {
      //Adds a new node with that value to the head of the
      Node Node = new Node(data);

      if(Head == null)
      {
        Head = Node;
      }else
      {
        Node.Next = Head;
        Head = Node;
      }
    }
    public bool includes(int data)
    {
      //returns true if that value exists as a node's value somewhere within the list
      //We have to check every element in the list
      bool result = false;

      Node currentNode = Head;

      while(currentNode != null)
      {
        if (currentNode.Data == data)
        {
          result = true;
          break;
        }
        currentNode = currentNode.Next;
      }

      return result;
    }
    public string ToString()
    {
      string liststring = "";
      Node currentNode = Head;

      while (currentNode != null)
      {
        liststring += String.Format("{0} -> ", currentNode.Data);
        currentNode = currentNode.Next;
      }

      return liststring + "NULL";
    }
  }

  public class Node
  {
    public int Data;
    public Node Next;

    public Node(int data)
    {
      Data = data;
      Next = null;
    }
  }
}
