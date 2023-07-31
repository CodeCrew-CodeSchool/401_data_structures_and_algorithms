namespace CodeChallenges
{
  public class CodeChallenge9
  {
    public static void ReverseLinkedList(LinkedListKth list)
    {
      Node previous = null;
      Node current = list.Head;
      Node temp = null;

      while (current != null)
      {
        temp = current.Next;
        current.Next = previous;
        previous = current;
        current = temp;
      }

      list.Head = previous;
    }

    public static bool IsPalindrome(LinkedListKth list)
    {
      LinkedListKth copyList = new LinkedListKth();
      Node node = list.Head;
      while (node != null)
      {
        Node newNode = new Node(node.Value);
        newNode.Next = copyList.Head;
        copyList.Head = newNode;
        node = node.Next;
      }

      Node originalCurrent = list.Head;
      Node copyCurrent = copyList.Head;

      while (originalCurrent != null && copyCurrent != null)
      {
        if (originalCurrent.Value != copyCurrent.Value)
        {
          return false;
        }
        originalCurrent = originalCurrent.Next;
        copyCurrent = copyCurrent.Next;
      }

      return originalCurrent == null && copyCurrent == null;
    }
  }
}
