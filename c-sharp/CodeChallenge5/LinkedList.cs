namespace CodeChallenges
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public void insert(int data)
    {
      //Adds a new node with that value to the head of the
      Node Node = new Node(data);
    }
    public bool includes(int data)
    {
      //returns true if that value exists as a node's value somewhere within the list
      //We have to check every element in the list
    }
    public string toString()
    {

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
