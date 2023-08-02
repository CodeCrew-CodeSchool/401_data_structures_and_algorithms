namespace CodeChallenges
{
  public class LinkedListKth : InsertableLinkedList
  {

    public int KthFromEnd(int kthFromEnd)
    {
      if (kthFromEnd < 0 || Head == null)
      {
        throw new Exception("Invalid input or kthFromEnd is negative");
      }
      Node fast = Head;
      Node slow = Head;

      for (int i = 0; i < kthFromEnd-1; i++)
      {
        // If the fast pointer reaches the end before making k moves, throw an exception
        if (fast.Next == null)
        {
          throw new Exception("k is larger than the size of the linked list");
        }
        fast = fast.Next;
      }

      while (fast.Next != null)
      {
        fast = fast.Next;
        slow = slow.Next;
      }

      // At this point, the slow pointer is at the kth from the end node
      return slow.Value;
    }

    
  }
}

