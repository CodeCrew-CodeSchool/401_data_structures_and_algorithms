using Xunit;
namespace CodeChallenges
{
  public class StackQueuePsuedo
  {


    private Stack<int> enqueueStack; // Stack for enqueue operation
    private Stack<int> dequeueStack; // Stack for dequeue operation

    public StackQueuePsuedo()
    {
      enqueueStack = new Stack<int>();
      dequeueStack = new Stack<int>();
    }

    public void Enqueue(int value)
    {
      // To enqueue, simply push the value onto the enqueueStack
      enqueueStack.Push(value);
    }

    public int Dequeue()
    {
      // If both stacks are empty, throw an exception as the queue is empty
      if (enqueueStack.Count == 0 && dequeueStack.Count == 0)
      {
        throw new InvalidOperationException("PseudoQueue is empty.");
      }

      // If dequeueStack is empty, transfer all elements from enqueueStack to dequeueStack
      if (dequeueStack.Count == 0)
      {
        while (enqueueStack.Count > 0)
        {
          dequeueStack.Push(enqueueStack.Pop());
        }
      }

      // Pop the top element from dequeueStack (front of the "queue")
      return dequeueStack.Pop();
    }

  }
}
