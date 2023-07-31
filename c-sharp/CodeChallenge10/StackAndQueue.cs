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
    public Node? Top { get; set; }

    public Stack(Node node)
    {
      Top = node;


        
    }
    public Stack()
    {
      Top = null;

    }



    public void Push(int value)
    {


      Node newNode = new Node(value);


      newNode.Next = Top;
      Top = newNode;

    }
    public bool IsEmpty()
    {
      if (Top == null)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public int Pop()
    {



      //if (Top == null)
      //{
      //  throw new Exception("Stack is empty");

      //}

      int value = Top.Value;
      Top = Top.Next;

      return value;

    }

    public int Peek()
    {
      if (Top == null)
      {
        throw new Exception("Oh no! Empty Stack");

      }

      return Top.Value;





    }



  }

  public class Queue
  {
    public Node Front { get; set; }
    public Node Back { get; set; }
    public Queue()
    {
      Front = null;
      Back = null;

    }

    public Queue(Node node)
    {
      Front = node;

    }

    public void Enqueue(int value)
    {
      Node newNode = new Node(value);

      if (Front == null)
      {
        Front = newNode;
        return;
      }

      Back.Next = newNode;
      Back = newNode;


    }


    public int Peek()
    {
      if (Front == null)
      {
        throw new Exception("Oh no! Empty Stack");

      }

      return Front.Value;

    }

    public int Dequeue()
    {

      if (Front == null)
      {
        throw new Exception("Stack is empty");
      }


      Node value = Front;
      Front.Next = Front;


      return value.Value;

    }

    public bool IsEmpty()
    {
      if (Front == null)
      {
        return false;
      }
      else
      {
        return true;
      }


    }
  }
}
