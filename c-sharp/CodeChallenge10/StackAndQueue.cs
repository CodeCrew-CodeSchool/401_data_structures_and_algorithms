namespace CodeChallenges
{
  public class Queue
  {
    private Node Front { get; set; }
    private Node Back { get; set; }

    public Queue(Node node)
    {
      Front = node;
      Back = node;
    }

    public void Enqueue(int value)
    {
      Node newNode = new Node(value);

      if (Front == null) // Empty queue
      {
        Front = newNode;
        // If the queue is empty, the new node will be both the Front and Back node.
        Back = newNode;
      }
      else if (Back == null)
      {
        // If the Back node is null, it means there is only one element in the queue.
        // In this case, the new node becomes the Back node, and the Front node's Next points to the Back node.
        Back = newNode;
        Front.Next = Back;
      }
      else
      {
        // If the Back node is not null, we add the new node to the Back and update the Back pointer.
        Back.Next = newNode;
        Back = newNode;
      }
    }

    public int Dequeue()
    {
      if (Front == null)
      {
        // Handle the case when trying to dequeue from an empty queue.
        // You can choose to return a default value or take any other appropriate action.
        // For example, you can return -1 or throw a custom exception, etc.
        return -1;
      }

      int value = Front.Value;
      Front = Front.Next;

      if (Front == null)
      {
        Back = null;
      }

      return value;
    }

    public int Peek()
    {
      if (Front == null)
      {
        throw new Exception("The queue is empty.");
      }

      return Front.Value;
    }

    public bool IsEmpty()
    {
      return Front == null;
    }
  }
}
