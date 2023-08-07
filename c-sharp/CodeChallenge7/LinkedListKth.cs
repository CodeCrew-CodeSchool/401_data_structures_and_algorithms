//namespace CodeChallenges
//{
//  public class LinkedListKth : InsertableLinkedList
//  {
//    public int KthFromEnd(int kthFromEnd)
//    {
//      if (kthFromEnd < 0)
//      {
//        throw new ArgumentException("Must be positive.");
//      }

//      Node fast = Head;
//      Node slow = Head;

//      for (int i = 0; i < kthFromEnd; i++)
//      {
//        if (fast == null)
//        {
//          throw new ArgumentException("Its too big, make it smaller.");
//        }
//        fast = fast.Next;
//      }

//      while (fast != null)
//      {
//        fast = fast.Next;
//        slow = slow.Next;
//      }

//      return slow.Value;
//    }
//  }
//}

namespace CodeChallenges
{
  public class LinkedListKth : InsertableLinkedList
  {
    public int KthFromEnd(int kthFromEnd)
    {
      if (kthFromEnd < 0)
      {
        throw new ArgumentException("Must be positive.");
      }

      Node fast = Head;
      Node slow = Head;

      for (int i = 0; i < kthFromEnd; i++)
      {
        if (fast == null)
        {
          throw new ArgumentException("Its too big, make it smaller.");
        }
        fast = fast.Next;
      }

      while (fast != null)
      {
        fast = fast.Next;
        slow = slow.Next;
      }

      return slow.Value;
    }
  }
}
