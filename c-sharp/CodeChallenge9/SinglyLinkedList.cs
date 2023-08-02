namespace CodeChallenges
{
  public class CodeChallenge9
  {
    public static LinkedListKth ReverseLinkedList(LinkedListKth list)
    {
      LinkedListKth reversedList = new LinkedListKth(); // Create a new linked list to store the reversed elements

      Node currentNode = list.Head;

      while (currentNode != null)
      {
        reversedList.Insert(currentNode.Value); // Insert the current node's value at the front of the reversed list
        currentNode = currentNode.Next;
      }

      list.Head = reversedList.Head; // Update the original list's head to point to the reversed list's head

      return reversedList;
    }


    public static bool IsPalindrome(LinkedListKth list)
    {
      Node slow = list.Head;
      Node fast = list.Head;
      Node prev = null;

      // Find the middle of the linked list and reverse the first half
      while (fast != null && fast.Next != null)
      {
        fast = fast.Next.Next;

        Node next = slow.Next;
        slow.Next = prev;
        prev = slow;
        slow = next;
      }

      // If the fast pointer reached the end, it's an odd-length list, so move slow to the next node
      if (fast != null)
      {
        slow = slow.Next;
      }

      // Compare the reversed first half with the second half directly
      while (prev != null && slow != null)
      {
        if (prev.Value != slow.Value)
        {
          return false;
        }

        prev = prev.Next;
        slow = slow.Next;
      }

      return true;
    }
  }
}
