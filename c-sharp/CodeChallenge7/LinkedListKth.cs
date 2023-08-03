namespace CodeChallenges
{
  public class LinkedListKth : InsertableLinkedList
  {

    public int KthFromEnd(int kthFromEnd)
    {
      if (kthFromEnd < 1)
      {
        throw new ArgumentException("kthFromEnd must be a postive value.");
      }

      if(kthFromEnd > Length)
      {
        throw new IndexOutOfRangeException("kthFromEnd must be <= length of list");
      }

      if(Length == 0)
      {
        throw new InvalidOperationException("Empty List");
      }

      Node? current = Tail;
      int count = 1;

      while (count < kthFromEnd )
      {
        current = current.Prev;
        count++;
      }

      return current.Value;

    }
  }
}