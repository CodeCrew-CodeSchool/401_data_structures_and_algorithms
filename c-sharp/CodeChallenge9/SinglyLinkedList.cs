namespace CodeChallenges
{
  public class CodeChallenge9
  {
    /// <summary>
    /// Reverses a singly linked list in place.
    /// </summary>
    /// <param name="list">The linked list to be reversed.</param>
    /// <returns>The reversed linked list.</returns>
    public static LinkedListKth ReverseLinkedList(LinkedListKth list)
    {
      Node prev = null;
      Node current = list.Head;
      Node next = null;

      // Reverse the pointers of the linked list nodes
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

    /// <summary>
    /// Determines if a singly linked list is a palindrome.
    /// </summary>
    /// <param name="list">The linked list to be checked.</param>
    /// <returns>True if the linked list is a palindrome, false otherwise.</returns>
    public static bool IsPalindrome(LinkedListKth list)
    {
      Node slow = list.Head;
      Node fast = list.Head;
      Stack<int> stack = new Stack<int>();

      // Traverse the linked list using slow and fast pointers, and push values onto the stack
      while (fast != null && fast.Next != null)
      {
        stack.Push(slow.Value);
        slow = slow.Next;
        fast = fast.Next.Next;
      }

      // Adjust slow pointer for odd-length list
      if (fast != null)
      {
        slow = slow.Next;
      }

      // Compare values from the stack with values in the remaining part of the linked list
      while (slow != null)
      {
        if (slow.Value != stack.Pop())
        {
          return false;
        }
        slow = slow.Next;
      }

      return true;
    }
  }
}
