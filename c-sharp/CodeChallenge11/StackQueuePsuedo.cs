using Xunit;
namespace CodeChallenges
{
  public class StackQueuePsuedo
  {
    private Stack stack1;
    private Stack stack2;

    public StackQueuePsuedo()
    {
      stack1 = new Stack();
      stack2 = new Stack();
    }

    public void Enqueue(int value)
    {
      while (!stack1.IsEmpty())
      {
        stack2.Push(stack1.Pop());
      }

      stack1.Push(value);

      while (!stack2.IsEmpty())
      {
        stack1.Push(stack2.Pop());
      }
    }

    public int Dequeue()
    {
      if (stack1.IsEmpty())
      {
        throw new InvalidOperationException("The PseudoQueue is empty");
      }
      return stack1.Pop();
    }
  }
}
