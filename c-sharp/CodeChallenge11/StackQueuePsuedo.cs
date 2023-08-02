using Xunit;
namespace CodeChallenges
{
  public class StackQueuePsuedo
  {
   public class PseudoQueue
    {

      private Stack stack1;
      private Stack stack2;

      public PseudoQueue()
      {
        stack1 = new Stack();
        stack2 = new Stack();
      }

      public void Enqueue(int value)
      {
        while (stack2.Count >0)
        {
          stack2.Push(stack1.Pop());
        }

        stack1.Push(value);

        while(stack2.Count > 0)
        {
          stack1.Push(stack2.Pop());
        }
      }

      public int Dequeue()
      {
        if (stack1.Count == 0)
        {
          throw new InvalidOperationException("The Pseudo is empty");
        }
        return (int)stack1.Pop();
      }
  }
}
