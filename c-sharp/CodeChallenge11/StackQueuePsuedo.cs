namespace CodeChallenges
{
  public class StackQueuePsuedo
  {
    // Stack used for enqueuing elements
    private Stack<int> enqueueStack = new Stack<int>();

    // Stack used for dequeuing elements
    private Stack<int> dequeueStack = new Stack<int>();

    // Method to enqueue an item into the pseudo queue
    public void Enqueue(int item)
    {
      enqueueStack.Push(item);
    }

    // Method to dequeue an item from the pseudo queue
    public int Dequeue()
    {
      // If the dequeue stack is empty, transfer elements from enqueue stack
      if (dequeueStack.Count == 0)
      {
        // If both stacks are empty, throw an exception
        if (enqueueStack.Count == 0)
        {
          throw new InvalidOperationException("Queue is empty.");
        }

        // Transfer elements from enqueue stack to dequeue stack
        while (enqueueStack.Count > 0)
        {
          dequeueStack.Push(enqueueStack.Pop());
        }
      }

      // Pop and return the front element from dequeue stack
      return dequeueStack.Pop();
    }
  }
}
