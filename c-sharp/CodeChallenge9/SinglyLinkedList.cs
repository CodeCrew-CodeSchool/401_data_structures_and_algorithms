namespace CodeChallenges
{
  public class CodeChallenge9
  {
    public static LinkedListKth ReverseLinkedList(LinkedListKth list)
    {
      if (list.Head == null)
      {
        throw new InvalidOperationException("Cannot reverse an empty list");
      }

      Node current = list.Head;
      Node prev = null;
      Node next;

      while (current != null)
      {
        next = current.Next;
        current.Next = prev;
        prev = current;
        current = next;

      }
      list.Head = prev;
      return list;
    }

    public static bool IsPalindrome(LinkedListKth list)
    {
      Node end = list.Tail;
      Node current = list.Head;

      while(current != null)
      {
        if(end.Value != current.Value)
        {
          return false;
        }
        current = current.Next;
        end = end.Prev;
      }
      return true;
    }
  }
}