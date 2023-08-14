using Xunit;
namespace CodeChallenges
{

  public class StackQueuePsuedo
  {
    public Stack Stack1 { get; set; } = new Stack();
    public Stack Stack2 { get; set; } = new Stack();

    public void Enqueue(int value)
    {
      if(Stack1.IsEmpty())
      {
        Stack1.Push(value);
      }
      else
      {
        while(Stack1.IsEmpty() == false)
        {
          int currentVal = Stack1.Pop();
          Stack2.Push(currentVal);
        }

        Stack1.Push(value);

        while(Stack2.IsEmpty() == false)
        {
          int currentVal = Stack2.Pop();
          Stack1.Push(currentVal);
        }
      }
    }

    public int Dequeue()
    {
      if (Stack1.IsEmpty())
      {
        throw new InvalidOperationException("Queue is empty");
      }


      return Stack1.Pop();
    }
  }
}