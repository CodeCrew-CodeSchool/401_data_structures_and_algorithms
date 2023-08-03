using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace CodeChallenges
{
  public class Node
  {
    public int Value { get; set; }

    public Node Next { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
    }
  }


  public class Stack
  {

    public Stack() { }
    public Node Top { get; set; }

    public Stack(Node node)
    {
      Top = node;
    }

    public void Push(int value)
    {
      Node newNode = new Node(value);
      newNode.Next = Top;
      Top = newNode;
    }

    public int Pop()
    {
      if (Top == null)
      {
        throw new Exception("Oh no! empty stack");
      }
      else
      {
        int value = Top.Value;
        Top = Top.Next;
        return value;
      }
    }

    public int Peek()
    {
      if (Top == null)
      {
        throw new Exception("Oh no! empty stack");
      }
      else
      {
        return Top.Value;
      }
    }

    public bool IsEmpty()
    {
      return Top == null;
    }
  }

  public class Queue
  {
    public Node Front { get; set; }
    public Node Back { get; set; }

    

    public Queue() { }
    public Queue(Node node)
    {
      Front = node;
      Back = node;
    }

    public int Peek()
    {
      if (Front == null)
      {
        throw new InvalidOperationException("Empty");
      }
      return Front.Value;
    }

    public void Enqueue(int value)
    {
      Node newNode = new Node(value);

      if (Front == null)
      {
        Front = newNode;
        Back = newNode;
        return;
      }

      Back.Next = newNode;
      Back = newNode;
    }

    public int Dequeue()
    {
      if (Front == null)
      {
        throw new InvalidOperationException("Empty");
      }
      else
      {
        int value = Front.Value;
        Front = Front.Next;
        if (Front == null)
        {
          Back = null;
        }
        return value;
      }
    }

    public bool IsEmpty()
    {
      return Front == null;
    }
  }
}
