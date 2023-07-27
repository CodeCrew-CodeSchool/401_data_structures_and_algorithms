namespace CodeChallenges
{
  /* public class LinkedList
   {
       // public Node Head {get; set;}

   }

   public class Node
   {

   }*/

  public class Node
  {
    public Node? Next { get; set; }
    public int Value { get; set; }



    public Node Last { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
      Last = null;
    }
  }


  public class LinkedList

  {
    public Node? Head { get; set; }

    public Node Tail { get; set; }
    //Miles "Tails" Prower
    public Node CurrentNode { get; set; }

    public LinkedList()
    {
      Head = null;
    }

    public void Insert(int value)
    {

      Node newNode = new Node(value);

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

    public bool Includes(int value)
    {
      bool foundValue = false;
      Node currentNode = Head;
      while (currentNode != null)
      {
        if (currentNode.Value == value)
        {
          foundValue = true;

        }
        currentNode = currentNode.Next;
      }
      return foundValue;
    }


    public string ToString()
    {
      string listString = "";
      Node currentNode = Head;

      while (currentNode != null)
      {
        listString += String.Format("{0} -> ", currentNode.Value);
        currentNode = currentNode.Next;
      }

      return listString + "NULL";
    }
  }

}
